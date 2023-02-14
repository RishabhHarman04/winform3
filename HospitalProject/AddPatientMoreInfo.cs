using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalProject
{
    internal class AddPatientMoreInfo
    {
       public int pid;
       public String sympt;
       public String diag ;
       public String medicine;
       public String ward;
       public String wardtype;
       public String date ;

        public AddPatientMoreInfo(int pid, string sympt, string diag, string medicine, string ward, string wardtype, string date)
        {
            this.pid = pid;
            this.sympt = sympt;
            this.diag = diag;
            this.medicine = medicine;
            this.ward = ward;
            this.wardtype = wardtype;
            this.date = date;
        }
    }
}
