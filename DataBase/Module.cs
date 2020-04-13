using System;
using System.Text.Json;

namespace ModulaIot.Controller.DataBase
{
    public class Module
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Device Device { get; set; }
        public string[] Capalilites { get; set; }
        public JsonDocument Value { get; set; }
    }
}