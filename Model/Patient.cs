using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotAssistant.Model
{
    public class Patient
    {
        public string id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string address { get; set; }

        public Patient()
        {
            this.id = "";
            this.name = "";
            this.phone = "";
            this.address = "";
        }
        public Patient(string id, string name, string phone, string address)
        {
            this.id = id;
            this.name = name;
            this.phone = phone;
            this.address = address;
        }

        public Patient(Patient d)
        {
            this.id = d.id;
            this.name = d.name;
            this.phone = d.phone;
            this.address = d.address;
        }
    }
}
