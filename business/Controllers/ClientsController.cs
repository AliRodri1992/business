using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using business.Resources;
using System.Data;
using Newtonsoft.Json;
using business.Models;
using System.Collections.Generic;

namespace business.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        [HttpGet]
        [Route("list")]
        public dynamic list_clients() {
            DataTable tClients = DBConnection.ListAll("client_list");
            string jsonClients = JsonConvert.SerializeObject(tClients);
            return new
            {
                success = true,
                message = "Success",
                result = new {
                    clients = JsonConvert.DeserializeObject<List<Client>>(jsonClients)
                }
            };
        }
    }
}
