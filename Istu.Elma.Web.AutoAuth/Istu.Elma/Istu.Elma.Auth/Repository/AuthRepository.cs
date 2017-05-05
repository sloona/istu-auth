using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Istu.Elma.Auth.Models;
using Istu.Elma.Auth.ElmaService;


namespace Istu.Elma.Auth.Repository
{
    class AuthRepository
    {
        public Models.Auth Create()
        {
            return new Models.Auth();
        }

        public void CreateElmaTask()
        {
            var elmaService = new WFPWebServiceSoapClient();
            var data = new WebData();
            var t = new WebDataItem();
            t.Name = "test"; t.Value = "test value";
            data.Items = new WebDataItem[] { new WebDataItem{Name = "testName", Value = "testValue" }, new WebDataItem { Name = "testName", Value = "testValue" }};
           elmaService.Run("userName", "password", "token", "instanceName", data);
        }
    }
}
