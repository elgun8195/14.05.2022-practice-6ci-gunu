using System;
using System.Collections.Generic;
using System.Text;

namespace _14._05._2022.Models
{
    internal class Weapon
    {
        private int _capacity;
        private int _gun;

        public int Capacity
        {
            get { return _capacity; }
            set
            {
                if (value>0)
                {
                    _capacity = value;
                }
            }
        }
        public int CurrentGun
        {
            get { return _gun; }
            set
            {
                if (value>=0&&value<=Capacity)
                {
                    _gun = value;
                }
            } }
        public bool IsSingle { get; set; } = true;


        public Weapon(int capacity,int currentgun,bool isSingle)
        {
            Capacity = capacity;
            CurrentGun = currentgun;
            IsSingle = isSingle;
        }


        public void Shot()
        {
            if (CurrentGun==0)
            {
                Console.WriteLine("Daraq Bosdur");
            }
            else
            {
                CurrentGun--;
                Console.WriteLine("Ates oldu" +", daraqda "+ CurrentGun +" gulle var");
            }
        }

        public void Fire()
        {
            if (CurrentGun == 0) Console.WriteLine("Daraq bosdur");

            else if(IsSingle==false)
            {
                int result=CurrentGun-CurrentGun;
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Daraq tekdedir deye avtomatik ates olmur");
            }

        }

        public int GetRemainBulletCount()
        {                           
            return Capacity - CurrentGun;
        }

        public int Reload()
        {
            int result = Capacity - CurrentGun;
            CurrentGun += result;
            return CurrentGun;
        }
        public bool ChangeFireMode()
        {
            if (IsSingle)
            {
                return IsSingle = false;
            }
            else
            {
               return IsSingle = true;
            }
        }
    }
}
