using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany.Domain.Entities.TokenModels
{
    public class ForToken
    {
        public Guid Id { get; set; } = new Guid();
        public string Name { get; set; }
        public string Agree { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
