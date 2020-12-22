using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace BoardingPasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Passenger[] passengers = new Passenger[5];
            for prompting to exit
            string answer = string.Empty;

            string inputstring;//generic input string
            int user;// this will indentify which type of user passenger or airline assisstant

            bool isValidInput = false;
            int totalPassenger = 0;
            const int totalNumberOfSeat = 5;
            int ticket = 0;//this will identify how many tickets user want to buy
            const int min = 30000;
            const int max = 999999;
            string response;//response to enter the main program or exit
            do
            {
                WriteLine("Please enter 1 to enter as a passenger or 2 to enter as a Airline Assistant: ");//Enter 1 or 2 to continue
                WriteLine("Please enter q/Q to Quit");//To quit
                inputstring = ReadLine();//Get input string
                if (inputstring == "q" || inputstring == "Q")//
                {
                    response = "q";
                    WriteLine("Good bye");
                }
                else if (inputstring == "1" || inputstring == "2")
                {
                    int.TryParse(inputstring, out user);
                    switch (user)
                    {
                        case 1:
                            Clear();
                            WriteLine("You have enter as a Passenger");
                            WriteLine();
                            int boardingPassessNumber;
                            boardingPassessNumber = Pass("how many pass you want to buy ?");
                            //Passenger newPassenger = new Passenger(boardingPassessNumber);
                            bool boardingPassessCheck = false;

                            while (boardingPassessCheck == false)
                            {
                                if (boardingPassessNumber == 0)
                                {
                                    WriteLine("Invalid input");
                                    break;
                                }
                                else if (boardingPassessNumber > totalNumberOfSeat)
                                {
                                    WriteLine("You can not buy that many passes!");
                                    break;
                                }
                                else
                                {
                                    boardingPassessCheck = true;
                                }
                            }

                            Passenger NewPassenger = new Passenger(boardingPassessNumber);
                            for (int j = 0; j < boardingPassessNumber; j++)
                            {

                                Clear();

                                string firstName = GetInput("First Name");
                                if (firstName.Length > 5)
                                {
                                    firstName = firstName.Substring(0, 5);
                                }
                                string lastName = GetInput("Last Name");
                                if (lastName.Length > 5)
                                {
                                    lastName = lastName.Substring(0, 5);

                                }
                                int securityNumber = GetSecurityNumber(min, max);

                                string currentTime = GetCurrentTime();

                                string departureTime = GetDepartureTime();

                                string departureGate = GetDepartureGate();

                                int seatNumber = GetSeat("Seat number");

                                WriteLine();
                                bool correntInput = false;
                                while (correntInput == false)
                                {
                                    string input = ReadLine();

                                    if (int.TryParse(input, out seatNumber) == true)
                                    {
                                        correntInput = true;
                                    }
                                    else
                                    {
                                        WriteLine("Invalid input, please try again");
                                    }
                                }

                            }


                            break;

                                else
                                {
                                bool boardingPassessCheck = false;
                                while (boardingPassessCheck == false)
                                {
                                    string inputTicket = inputstring;
                                    if (int.TryParse(inputstring, out ticket) == true)
                                    {
                                        boardingPassessCheck = true;
                                    }
                                    else if (int.TryParse(inputstring, out ticket) == false)
                                    {
                                        WriteLine("Invalid input, please try again!");
                                        boardingPassessCheck = true;
                                    }
                                }
                                if (ticket > 40 || ticket < 1)
                                {
                                    WriteLine("Invalid seat input");
                                }
                                else
                                {
                                    for (int j = 0; j < ticket; j++)
                                    {

                                        Clear();
                                        Passenger NewPassenger = new Passenger();
                                        string firstName = GetInput("First Name");
                                        if (firstName.Length > 5)
                                        {
                                            firstName = firstName.Substring(0, 5);
                                        }
                                        string lastName = GetInput("Last Name");
                                        if (lastName.Length > 5)
                                        {
                                            lastName = lastName.Substring(0, 5);

                                        }
                                        int securityNumber = RandomNumber(min, max);

                                        string currentTime = GetCurrentTime();

                                        string departureTime = GetDepartureTime();

                                        WriteLine("Please choose the seat from the following list: ");
                                        WriteLine();
                                        for (int i = 0; i < passengers.Length; i++)
                                        {
                                            bool isTheSeatOpen = true;//check if the seat is availible is automaticly asume that it is availible
                                            int seat = i + 1;
                                            for (int k = 0; k < passengers.Length; k++)
                                            {
                                                if (passengers[k] != null && seat == passengers[k].SeatNumber)
                                                {
                                                    isTheSeatOpen = false;
                                                    break;
                                                }
                                            }
                                            if (isTheSeatOpen == true)
                                            {
                                                Write(seat + " ");
                                            }
                                        }

                                        WriteLine();
                                        bool correntInput = false;
                                        int seatNumber = 0;
                                        while (correntInput == false)
                                        {
                                            string input = ReadLine();

                                            if (int.TryParse(input, out seatNumber) == true)
                                            {
                                                correntInput = true;
                                            }
                                            else
                                            {
                                                WriteLine("Invalid input, please try again");
                                            }
                                        }
                                        NewPassenger.FName = firstName;
                                        NewPassenger.LName = lastName;
                                        NewPassenger.SecurityNumber = securityNumber;
                                        NewPassenger.SeatNumber = seatNumber;

                                        passengers[totalPassenger] = NewPassenger;
                                        totalPassenger++;

                                        //NewPassenger.FName[i] = GetInput("First name");
                                        //NewPassenger.LName[i] = GetInput("Last name");
                                        //NewPassenger.SecurityNumber[i] = GetSecurityNumber();
                                    }
                                }

                                //Passenger.Display(passengers);
                            }
                        case 2:
                            WriteLine("You have enter as an Airline Assistant");
                            break;

                        default:
                            WriteLine("Invalid input please try again.Only press 1 or 2");
                            break;

                    }
                }
                else
                {
                    WriteLine("Invalid input please try again");
                }
                //WriteLine("{0} is an invalid input", user);
            }
                else if (response == "q" || response == "Q")
            {
                WriteLine("Goodbye");
            }
            else
            {
                WriteLine("Invalid input");
            }
        } while (response != "q" && response != "Q");

            ReadKey();

    }//End of method

    public static string GetInput(string what)
    {
        WriteLine("Please enter your {0}", what);
        string input = ReadLine();
        return input;
    }

    public static int GetSecurityNumber(int SecurityNumber)
    {
        RandomNumber random = new RandomNumber();
        int SecurityNumber =
        WriteLine("Your security Number is : {0}", SecurityNumber);
    }

    public static int GetSecurityNumber(int min, int max)
    {
        Random random = new Random();
        return random.Next(min, max);
    }

    public static string GetCurrentTime()
    {
        string now = DateTime.Now.ToString("MMMM dd, yyyy");
        return now;
    }

    public static string GetDepartureTime()
    {
        string time = "30-06-2019";
        return time;
    }

    public static string GetDepartureGate()
    {
        string gate = "k8";
        return gate;
    }

    public static int Pass(string what)
    {
        WriteLine("Please enter {0}", what);
        int Pass;
        if (int.TryParse(ReadLine(), out Pass) == false)
        {
            return 0;
        }
        return Pass;
    }

    public static int GetSeat(string what)
    {
        WriteLine("Please enter your {0}", what);
        int seatNumber;
        bool seatInputCheck = false;
        bool seatInputNumber = false;
        do
        {
            string seatInput = ReadLine();
            int.TryParse(seatInput, out seatNumber);
            if (int.TryParse(seatInput, out seatNumber) == false)
            {
                WriteLine("Invalid Input, please enter a number");
            }
            else
            {
                seatInputCheck = true;
            }
        }
        while (seatInputCheck == false);

        do
        {
            if (seatNumber > 40 || seatNumber < 1)
            {
                WriteLine("Invalid Input, please enter a seat number from 1 to 40");
            }
            else
            {
                seatInputNumber = true;
            }
        }
        while (seatInputNumber == false);
        return seatNumber;

    }

}//End of class

        
}//End of namespace
