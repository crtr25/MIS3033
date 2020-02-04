using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Classes
{
    class EntryForm
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int ZipCode { get; set; }


        public EntryForm()
        {
            Name = string.Empty;
            Address = string.Empty;
            ZipCode = 0;
        }
        public EntryForm(string name, string address, int zipCode)
        {
            Name = name;
            Address = string.Empty;
            ZipCode = 0;
        }
        public override string ToString()
        {
         string answer =($"{Name}, {Address}, {ZipCode.ToString()}");
            return answer;
        }
    }


    
}
