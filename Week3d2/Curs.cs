using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3d2
{
    class Curs
    {
        public int CursId { get; set; }        // campuri
        protected string Nume{ get; set; } 
        private int Durata{ get; set; } 

        //public Curs(int cursId, string nume, int durata)//constructor
        //{
        //    CursId = cursId;
        //    Nume = nume;
        //    Durata = durata;
        //    //Durata=12; ii putem da valoare, sau putem sa nu o declaram deloc aici
          
        //}
        //public Curs(string nume, int durata) //al 2 lea constructor, cu caracteristici diferite
        //{
        //    Nume = nume;
        //    Durata = durata;
        //}
        public void SetareCurs(int id, string nume)
        {
            CursId = id;
            Nume = nume;
        }
    }

}

