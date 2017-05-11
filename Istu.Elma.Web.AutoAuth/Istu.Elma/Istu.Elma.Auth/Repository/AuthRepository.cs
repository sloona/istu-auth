using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Istu.Elma.Auth.Models;
using Istu.Elma.Auth.ElmaServiceReference;




namespace Istu.Elma.Auth.Repository
{
    public class AuthRepository
    {
        public Models.Auth Create()
        {
            return new Models.Auth();
        }

        //public long CreateElmaTask(string Fio = "", string Email = "", string token = "", string instanceName = "")
        public long CreateElmaTask(Models.Auth model)
        {
            try {
                WFPWebServiceSoapClient elmaClient = new WFPWebServiceSoapClient("WFPWebServiceSoap");
                var data = new WebData();
                data.Items = new WebDataItem[] { new WebDataItem { Name = "Fio", Value = model.FullName }, new WebDataItem { Name = "Email", Value = model.Email } };
                return elmaClient.Run("service", "Password_123", model.Token, model.InstanceName, data);
                //return elmaClient.Run("service", "Password_123", "16040229-1144-42b7-9dff-33e1c03c01f3", "Реквизиты доступа к системе Элма", data);
            } catch
            {
                return 0;
            }
        }
    }
}
