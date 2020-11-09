using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3d2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Curs cursulMeuAutomation = new Curs(1,"Testare automatizata", 12);//o instanta a clasei= un obiect
            //Curs cursulMeuJava = new Curs("Java", 14);  

            
            Tutorial MyTutorial = new Tutorial();
            MyTutorial.SetareCurs( 2, "miercuri");
            Console.ReadLine();
        }
    }
}
