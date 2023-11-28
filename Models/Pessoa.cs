using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Threading.Tasks;

namespace Models
{
    public class Pessoa{
        public string Name { get; set; }
        public int Age { get; set; }

        public void Hello(){
            Console.WriteLine($"Olá, meu nome é {Name} e tenho {Age} anos.");
        }
    }
}