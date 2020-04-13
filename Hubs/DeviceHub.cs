using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using ModulaIot.Controller.DataBase;

namespace ModulaIot.Controller.Hubs
{
    public class DeviceHub : Hub
    {

        private readonly ModulaIotContext _context;

        public DeviceHub(ModulaIotContext context)
        {
            _context = context;
        }
        public string Inform(string val)
        {
            var isAdopted = false;
            if (isAdopted) return "";
            return "";
        }
    }
}
