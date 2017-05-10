using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Istu.Elma.Auth.Models;
using Istu.Elma.Auth.ElmaService;


namespace Istu.Elma.Auth.Repository
{
    public class AuthRepository
    {
        public Models.Auth Create()
        {
            return new Models.Auth();
        }

        public void CreateElmaTask(string Fio="", string Email = "")
        {
            var elmaService = new WFPWebServiceSoapClient();
            var data = new WebData();
            //var t = new WebDataItem();
            //t.Name = "test"; t.Value = "test value";
            data.Items = new WebDataItem[] { new WebDataItem{Name = "Fio", Value = Fio }, new WebDataItem { Name = "Email", Value = Email }};
            elmaService.Run("service", "Password_123", "16040229-1144-42b7-9dff-33e1c03c01f3", "Реквизиты доступа к системе Элма", data);
        }
    }
}
