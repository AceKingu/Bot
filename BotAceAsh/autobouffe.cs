using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using WindowsInput;
using System.Windows.Forms;

namespace BotAceAsh
{
    class Autobouffe
    {
        Random rand = new Random(); //rand pour le + ou - 5s
        public int Compteur { get; private set; }
        bool IsRunning { get; set; }

        public Autobouffe(int nombreDeBouffes)
        {
            IsRunning = true;
            Compteur = 0;
            while (IsRunning)
            {
                if(Compteur >= nombreDeBouffes)
                {
                    Compteur = 0; //reset
                }
                Compteur++;
                MangerBouffe(Compteur); //lance une bouffe en fonction du compteur
                Wait(1000); // attente de 30 mins
            }
        }

        public void Wait(int time)
        {
            Thread.Sleep(time + rand.Next(1000, 4000));
        }

        public void MangerBouffe(int i)
        {
            switch (i)
            {
                case 1:
                    SendKeys.Send("{F4}");
                    Console.WriteLine("F4\n");
                    break;
                case 2:
                    SendKeys.Send("{F5}");
                    Console.WriteLine("F5\n");
                    break;
                case 3:
                    SendKeys.Send("{F6}");
                    Console.WriteLine("F6\n");
                    break;
                default:
                    SendKeys.Send("{F7}");
                    Console.WriteLine("F7\n");
                    break;
            }
        }
    }
}
