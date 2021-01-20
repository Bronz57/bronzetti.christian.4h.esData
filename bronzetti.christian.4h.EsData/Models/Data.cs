using System;
using System.Collections.Generic;
using System.Text;

namespace bronzetti.christian._4h.EsData.Models
{
    class Data
    {
        int _giorno;
        int _mese;
        int _anno;

        public int Giorno
        { 
            get
            {
                return _giorno;
            }

            set
            {
                _giorno = value;
            }
        }
        public int Mese
        {
            get
            {
                return _mese;
            }

            set
            {
                _mese = value;
            }
        }
        public int Anno 
        {
            get
            {
                return _anno;
            }

            set
            {
                _anno = value;
            }
        }

        public Data(int g, int m, int a)
        {
            _giorno = g;
            _mese = m;
            _anno = a;
        }

        public string Out(Data d)
        {
            string g = d._giorno.ToString();
            string m = d._mese.ToString();
            string a = d._anno.ToString();

            if (d._giorno < 10)
                g = "0" + g;

            if (d._mese < 10)
                m = "0" + m;

            if (d._anno < 10)
                a = "0" + a;

            return $"{g}/{m}/{a}";

        }


        public void Mod(int g, int m, int a)
        {
            //alla chiamata di mod modifico la vada che però deve essere corretta quindi la proprietà e non il campo private
            Giorno = g; 
            Anno = a;
            Mese = m;
        }
  
        public bool Val(Data d)
        {
            bool f = true;  //flag di controllo

            if (d._anno>= 0) //se minore di 0 sarebbe avanti cristo ? ;D
                f = true;
            
            if(d._mese > 0 && d._mese < 13) //controla se il mese è compreso tra 1 e 12
                f = true;

            if (d._giorno > 0 && d._giorno < 32) //se è compreso tra 1 e 31
                f = true;

            if (d._mese == 2 && d._giorno > 28)
                f = false;
            
            
            if (d._giorno == 29 && d._mese == 2)
            {
                if (ControlloBisestile(d._anno) == true && d._mese == 2 && d._giorno == 29)
                    f = true;
            }
           
                
                
                   
                            

            return f;
        }

        private bool ControlloBisestile(int a)
        {

            if (a % 400 == 0 || (a % 4 == 0 && a % 100 != 0))
                return true;
            else
                return false;
        }



    }
}
