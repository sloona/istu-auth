using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Istu.Elma.Auth.Models
{
    class Auth
    {
        [DisplayName("ФИО")]
        public string FullName { get; set; }

        [DisplayName("Email")]
        public string Email { get; set; }
    }
}
