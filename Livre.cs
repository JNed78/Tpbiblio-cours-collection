using System;
using System.Collections.Generic;
using System.Text;

namespace Tpbiblio
{
    class Livre
    {
        private string co;
        private string ti;
        private int an;
        private string ed;
        private string aut;

        public string Co
        {
            get => co; set => co = value;
        }
        public string Ti
        {
            get => ti; set => ti = value;
        }
        public string Ed
        {
            get => ed; set => ed = value;
        }
        public string Aut
        {
            get => aut; set => aut = value;
        }
        public int An
        {
            get => an; set => an = value;
        }

        public Livre(string co, string ti, string ed, string aut, int an)
        {
            this.Co = co;
            this.Ti = ti;
            this.Ed = ed;
            this.Aut = aut;
            this.An = an;
        }
        public override string ToString()
        {
            return Co + "/"+ Ti + "/" + Ed + "/" + Aut + "/" + An + ", ";
        }
        public string getAut()
        {
            return Aut;
        }
        public string getEd()
        {
            return Ed;
        }


    }
}
