using System;
using System.IO;
using Internship.Core.DomainModels.SSOT; 
using Microsoft.AspNetCore.Http;

namespace Internship.Web.Helpers
{
    public static class PopupHelper
    {
        public static string HiddenLink(string id, string link)
        {
            return $" <a id='{id}' href='{link}' data-fancybox data-type='iframe'></a> ";
        }
    }
}