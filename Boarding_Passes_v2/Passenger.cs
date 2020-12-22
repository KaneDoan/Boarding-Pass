using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BoardingPasses
{
    class Passenger
    {
        private string fName;

        private string lName;

        private int securityNumber;

        private int seatNumber;

        private string currentTime;

        private string departureTime;

        private string departureGate;


        //public Passenger(int SizeOfArray)
        //{
        //    Fname = new string;

        //    Lname = new string;

        //    seatNumber = new int;

        //    securityNumber = new int;

        //    currentTime = new string;

        //    departureTime = new string;

        //    departureGate = new string;


        //}

        public string FName
        { get { return fName; }
          set { fName = value; }
        }

        public string LName
        { get { return lName; }
          set { lName = value; }
        }

        public int SeatNumber
        {
            get { return seatNumber; }
            set { seatNumber = value; }
        }

        public int SecurityNumber
        {
            get { return securityNumber; }
            set { securityNumber = value; }
        }

        public string CurrentTime
        {
            get { return currentTime; }
            set { currentTime = value; }
        }

        public string DepartureTime
        {
            get { return departureTime; }
            set { departureTime = value; }
        }

        public string DepartureGate
        {
            get { return departureGate; }
            set { departureGate = value; }
        }

        //public void Checkseat( int SeatNumber)
        //{
        //    for (int i = 0; i < seatNumber.Length; i++)
        //    {
        //        if (seatNumber[i] == 0)
        //        {
        //            Console.Write("No.{0}", i + 1);
        //        }

        //        else if (seatNumber[i] != 0)
        //        {
        //            Console.Write("[Not Empty]");
        //        }

        //    }

        //}

        public  void Display(Passenger[] Passenger)
        {
            for (int i = 0; i < fName.Length; i++)
            {
                WriteLine("The passenger First name is {0}", fName);
                WriteLine("The passenger Last name is {0}", lName);
                WriteLine("The passenger SeatNumber is {0} ", seatNumber);
                WriteLine("The passenger SecurityNumber is {0}", securityNumber);
                WriteLine("The passenger CurrentTime is {0}", currentTime);
                WriteLine("The passenger DepartureTime is {0}", departureTime);
                WriteLine("The passenger DepartureGate is {0}", departureGate);
                WriteLine("________----___________________-_---______________-_\n");
            }
        }
    }

}
