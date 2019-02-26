using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_TankFight.World_of_Tanks
{
    class Tank
    {
        private string Name;
        private int Ammunition;
        private int Armor;
        private int Maneuverability;

        public static Random rnd = new Random();

        public Tank(string name)
        {
            this.Name = name;
            this.Ammunition = (int)rnd.Next(0, 100);
            this.Armor= (int)rnd.Next(0, 100);
            this.Maneuverability= (int)rnd.Next(0, 100);
        }

        public string GetName()
        {
            return this.Name;
        }
        public string GetAmmun()
        {
            string res = string.Format("Боекомплект: {0}%", Ammunition);
            return res;
        }
        public string GetArmor()
        {
            string res = string.Format("Боекомплект: {0}%", Armor);
            return res;
        }
        public string GetManeu()
        {
            string res = string.Format("Боекомплект: {0}%", Maneuverability);
            return res;
        }
        public string GetInfo()
        {
            string res = string.Format("Боекомплект: {0}%\nУроень брони: {1}%\nУровень маневренности: {2}%", Ammunition, Armor, Maneuverability);
            return res;
        }

        public static bool operator *(Tank t1, Tank t2)
        {
            int t1_count = 0, t2_count = 0;
            if (t1.Ammunition > t2.Ammunition)
                t1_count++;
            else
                t2_count++;
            if (t1.Armor > t2.Armor)
                t1_count++;
            else
                t2_count++;
            if (t1.Maneuverability > t2.Maneuverability)
                t1_count++;
            else
                t2_count++;
            if (t1_count > t2_count)
                return true;
            else
                return false;
        }


    }
}
