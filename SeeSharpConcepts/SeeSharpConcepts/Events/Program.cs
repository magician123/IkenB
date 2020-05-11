using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Shooter shooter = new Shooter();

           
            shooter.KillingCompleted += ConsumeBullets;

            shooter.OnShoot();

            Console.ReadLine();
        }

        public static void ConsumeBullets(object sender, EventArgs e)
        {
            Console.WriteLine("I was shot .....");
        }
    }

    class Shooter
    {
        public delegate void KilingHander(object sender, EventArgs e);

        public event KilingHander KillingCompleted;

        public void OnShoot()
        {
            if(KillingCompleted != null)
            {
                KillingCompleted.Invoke(this, EventArgs.Empty);
                Console.WriteLine("shooting.......");
            }
            
        }
    }
}
