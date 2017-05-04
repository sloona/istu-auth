using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Istu.Elma.Auth.Models;

namespace Istu.Elma.Auth.Repository
{
    class AuthRepository
    {
        public Istu.Elma.Auth.Models.Auth Create()
        {
            return new Istu.Elma.Auth.Models.Auth();
        }

        public void CreateElmaTask()
        {

        }
    }
}
