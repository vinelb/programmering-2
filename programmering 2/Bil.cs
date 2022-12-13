using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programmering2
{
    public class Bil
    {
        private int däck = 4;
        private string färg = "grå";
        private string Motortyp = "bensin-motor";
        public int getDäck()
        {
            return this.däck;
        }
        public string getFärg()
        {
            return this.färg;
        }
        public void setFärg(string färg)
        {
            this.färg = färg;

        }

        public string getMotortyp()
        {
            return this.Motortyp;
        }

        public void setMotortyp(string Motortyp)
        {
            this.Motortyp = Motortyp;
        }
    }   
         

}

