using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3d2
{
    class Tutorial:Curs
    {
        public void RenameTutorial(int tutorialId, string tutorialName)
        {
            CursId = tutorialId;
            Nume = tutorialName;
        }
    }
}
