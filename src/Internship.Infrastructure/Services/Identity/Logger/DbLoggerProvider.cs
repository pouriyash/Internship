﻿using Internship.Core.Common.GuardToolkit;
using Internship.Infrastructure.DataLayer.Context;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Internship.Core.DomainModels.Entity.Identity;
using Internship.Core.DomainModels.ViewModel.Identity.Settings;

namespace Internship.Infrastructure.Services.Identity.Logger
{
    public class DbLoggerProvider : ILoggerProvider
    {
        private readonly TimeSpan _interval = TimeSpan.FromSeconds(2);
        private readonly IServiceProvider _serviceProvider;
        private readonly IList<AppLogItem> _currentBatch = new List<AppLogItem>();

        private readonly BlockingCollection<AppLogItem> _messageQueue =
            new BlockingCollection<AppLogItem>(new ConcurrentQueue<AppLogItem>());

        private readonly Task _outputTask;
        private readonly CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();
        private readonly IOptions<SiteSettings> _siteSettings;

        public DbLoggerProvider(
            IOptions<SiteSettings> siteSettings,
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _serviceProvider.CheckArgumentIsNull(nameof(_serviceProvider));

            _siteSettings = siteSettings;
            _siteSettings.CheckArgumentIsNull(nameof(_siteSettings));

            _outputTask = Task.Run(processLogQueue);
        }

        public ILogger CreateLogger(string categoryName)
        {
            return new DbLogger(this, _serviceProvider, categoryName, _siteSettings);
        }

        public void Dispose()
        {
            stop();
        }

        internal void AddLogItem(AppLogItem appLogItem)
        {
            if (!_messageQueue.IsAddingCompleted)
            {
                _messageQueue.Add(appLogItem, _cancellationTokenSource.Token);
            }
        }

        private async Task processLogQueue()
        {
            while (!_cancellationTokenSource.IsCancellationRequested)
            {
                while (_messageQueue.TryTake(out var message))
                {
                    try
                    {
                        _currentBatch.Add(message);
                    }
                    catch
                    {
                        //cancellation token canceled or CompleteAdding called
                    }
                }

                await saveLogItemsAsync(_currentBatch, _cancellationTokenSource.Token);
                _currentBatch.Clear();

                await Task.Delay(_interval, _cancellationTokenSource.Token);
            }
        }

        private async Task saveLogItemsAsync(IList<AppLogItem> appLogItems, CancellationToken cancellationToken)
        {
            try
            {
                if (!appLogItems.Any())
                {
                    return;
                }

                // We need a separate context for the logger to call its SaveChanges several times,
                // without using the current request's context and changing its internal state.
                using (var scope = _serviceProvider.GetRequiredService<IServiceScopeFactory>().CreateScope())
                {
                    using (var context = scope.ServiceProvider.GetRequiredService<IUnitOfWork>())
                    {
                        await context.Set<AppLogItem>().AddRangeAsync(appLogItems, cancellationToken);
                        await context.SaveChangesAsync(cancellationToken);
                    }
                }
            }
            catch
            {
                // don't throw exceptions from logger
            }
        }

        private void stop()
        {
            _cancellationTokenSource.Cancel();
            _messageQueue.CompleteAdding();

            try
            {
                _outputTask.Wait(_interval);
            }
            catch (TaskCanceledException)
            {
            }
            catch (AggregateException ex) when (ex.InnerExceptions.Count == 1 &&
                                                ex.InnerExceptions[0] is TaskCanceledException)
            {
            }
        }
    }
}