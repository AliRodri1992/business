using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using business.Resources;
using System.Data;
using Newtonsoft.Json;
using business.Models;
using System.Collections.Generic;

namespace business.Controllers
{
    [ApiController]
    [Route("clients")]
    public class ClientsController : Controller
    {
        [HttpGet]
        [Route("list")]
        public dynamic list_clients() {
            System.Diagnostics.Debug.WriteLine("SomeText");
            DataTable tClients = DBConnection.ListAll("client_list");
            string jsonClients = JsonConvert.SerializeObject(tClients);
            List<Client> clients;
            return new
            {
                success = true,
                message = "Success",
                result = new {
                    clients = JsonConvert.DeserializeObject<List<Client>>(jsonClients)
                }
            };
        }

        // [HttpGet]
        // [Route("create")]
        // public dynamic create() { }
    }
}
