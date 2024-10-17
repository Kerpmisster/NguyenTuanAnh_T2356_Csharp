using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lab4._5.MultiInterface;

namespace Lab4._5
{
    internal class Car : IMovable
    {
        private bool started = false;
        public bool Started {
            get { return started; }

        }

        public void Accelerate()
        {
            Console.WriteLine("car accelerating ");
        }

        public void Brake()
        {
            Console.WriteLine("car braking");
        }


        public void TurnLeft()
        {
            Console.WriteLine("car turning left");
        }

        public void TurnRight()
        {
            Console.WriteLine("car turning right");
        }

        public void Start()
        {
            Console.WriteLine("car started");
            started = true;
        }

        public void Stop()
        {
            Console.WriteLine("car stopped");
            started = false;
        }
    }
}
