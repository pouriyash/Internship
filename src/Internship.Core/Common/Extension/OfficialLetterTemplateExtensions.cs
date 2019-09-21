using Internship.Core.DomainModels.DTO.OfficialLetterTemplate;
using System.Collections.Generic;


namespace Internship.Core.Common.Extension
{
    public static class OfficialLetterTemplateExtensions
    {
        public static OfficialLetterTemplateDto Compile(this OfficialLetterTemplateDto letter, Dictionary<string, string> keyValuePairs)
        {
            var body = letter.Body;

            foreach (var pair in keyValuePairs)
            {
                body = body.Replace("{{ " + pair.Key + " }}", pair.Value);
            }

            letter.Body = body;

            return letter;
        }
    }
}
