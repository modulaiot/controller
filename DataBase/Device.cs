using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ModulaIot.Controller.DataBase
{
    public class Device
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public List<Module> Modules { get; set; }
    }
}
