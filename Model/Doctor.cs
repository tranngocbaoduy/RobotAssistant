using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotAssistant.Model
{
    public class Doctor
    {
        public string id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string address { get; set; }

        public Doctor()
        {
            this.id = "";
            this.name = "";
            this.phone = "";
            this.address = "";
        }
        public Doctor(string id, string name, string phone, string address)
        {
            this.id = id;
            this.name = name;
            this.phone = phone;
            this.address = address;
        }

        public Doctor(Doctor d)
        {
            // vì từng property trong doctor là kiểu value type
            // nên là sẽ trả ra giá trị
            // nếu là reference type thì trả ra địa chỉ 
            this.id = d.id;
            this.name = d.name;
            this.phone = d.phone;
            this.address = d.address;
        }

    }
}
