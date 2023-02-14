using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject
{
    internal class AddPatientInfo
    {
        public String name ;
        public String address;
        public Int64 contact;
        public int age;
        public String gender;
        public String blood;
        public String any;
        public int pid;

        public AddPatientInfo(string name, string address, long contact, int age, string gender, string blood, string any, int pid)
        {
            this.name = name;
            this.address = address;
            this.contact = contact;
            this.age = age;
            this.gender = gender;
            this.blood = blood;
            this.any = any;
            this.pid = pid;
        }
    }
}
