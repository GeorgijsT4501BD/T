using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecrypt_Serialize_BD
{
    interface MovementSpeed
    {
        void Speed();
    }
    public abstract class Vehicle
    {
        public int a { get; set; }
        public int b { get; set; }

        public abstract void Summ();// may be not realized but have to be in subclasses
        public virtual void Abc()//must be realized but may not to be in sub classes
        {
        }
        public double NotSumm()
        {
            return a / b;
        }
    }

    public class Car : Vehicle, MovementSpeed
    {
        //this class gets Vehicles fields and methods
        public void Speed()
        {
        }
        public override void Summ()
        {
            Console.Write("qwerty", base.NotSumm());
        }
    }
}
