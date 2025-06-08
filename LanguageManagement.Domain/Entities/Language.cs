using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageManagement.Domain.Entities
{
    public class Language
    {
        public string Id { get; private set; }
        public string? Name { get; private set; }
        public string? CultureCode { get; private set; }
        public string? ShortCode { get; private set; }
        public bool IsActive { get; private set; }
        public DateTime InsertTime { get; private set; }

        public Language(string id, string? name, string? cultureCode, string? shortCode, bool isActive, DateTime insertTime)
        {
            Id = id;
            Name = name;
            CultureCode = cultureCode;
            ShortCode = shortCode;
            IsActive = isActive;
            InsertTime = insertTime;
        }
    }
}
