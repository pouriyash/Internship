﻿using System;
using System.Linq;
using Internship.Core.Common.GuardToolkit;
using Microsoft.AspNetCore.Identity;
using Internship.Core.Common.PersianToolkit;
using DNTPersianUtils.Core;

namespace Internship.Infrastructure.Services.Identity
{
    public class CustomNormalizer : ILookupNormalizer
    {
        public string Normalize(string key)
        {
            if (string.IsNullOrWhiteSpace(key))
            {
                return null;
            }

            key = key.Trim();

            if (key.IsEmailAddress())
            {
                key = FixGmailDots(key);
            }
            else
            {
                key = key.ApplyCorrectYeKe()
                    .RemoveDiacritics()
                    .CleanUnderLines()
                    .RemovePunctuation();
                key = key.Trim().Replace(" ", "");
            }

            key = key.ToUpperInvariant();
            return key;
        }

        private static string FixGmailDots(string email)
        {
            email = email.ToLowerInvariant().Trim();
            var emailParts = email.Split('@');
            var name = emailParts[0].Replace(".", string.Empty);

            var plusIndex = name.IndexOf("+", StringComparison.OrdinalIgnoreCase);
            if (plusIndex != -1)
            {
                name = name.Substring(0, plusIndex);
            }

            var emailDomain = emailParts[1];
            emailDomain = emailDomain.Replace("googlemail.com", "gmail.com");

            string[] domainsAllowedDots =
            {
                "gmail.com",
                "facebook.com"
            };

            var isFromDomainsAllowedDots = domainsAllowedDots.Any(domain => emailDomain.Equals(domain));
            return !isFromDomainsAllowedDots ? email : $"{name}@{emailDomain}";
        }
    }
}