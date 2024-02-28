using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MyCompany.Domain.Entities.Models
{
    public class EmailModels
    {
        [EmailAddress]
        public string To { get; set; }
        public string Subject { get; set; }

        [JsonIgnore]
        // Bodyni ignore qiladi
        public string? Body { get; set; }
    }
}
