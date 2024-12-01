using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionManagement.Data
{
    // Vytas Gadliauskas Macros class
    internal class Macros
    {
        public string name { get; set; }
        public string commands { get; set; }

        public Macros() { }

        public Macros(string name, string commands)
        {
            this.name = name;
            this.commands = commands;
        }
    }
}
