using System;

namespace URLEncoder
{
    class Invalid
    {
        Url Url = new Url();
        public void Check()
        {
            Console.WriteLine("Your input is invalid because it contains a control character, please enter a new number");
            Url.Input();
        }
    }

    class Invalid2
    {
        Url Url = new Url();
        public void Check()
        {
            Console.WriteLine("Your input is invalid because it contains a control character, please enter a new number");
            Url.Input2();
        }
    }


    class Url
    {
        string encodedValue = "";
        string encodedValue2 = "";
        public void Input()
        {
            Console.WriteLine("Please enter the project name");
            var project_name = Console.ReadLine();
            foreach (char c in project_name)
            {
                int d = (int)c;
                if (65 <= d && d <= 90)
                {
                    encodedValue += c;
                }
                else if (97 <= d && d <= 122)
                {
                    encodedValue += c;
                }
                else if (d <= 31 || d == 127)
                {
                    Invalid second = new Invalid();
                    second.Check();
                }
                else
                {
                    string hexValue = d.ToString("x");
                    encodedValue = encodedValue + "%" + hexValue;
                }
            }
        }
        public void Input2()
        {
            Console.WriteLine("Please enter the activity name");
            var project_name = Console.ReadLine();
            foreach (char c in project_name)
            {
                int d = (int)c;
                if (65 <= d && d <= 90)
                {
                    encodedValue2 += c;
                }
                else if (97 <= d && d <= 122)
                {
                    encodedValue2 += c;
                }
                else if (d <= 31 || d == 127)
                {
                    Invalid2 second = new Invalid2();
                    second.Check();
                }
                else
                {
                    string hexValue = d.ToString("x");
                    encodedValue2 = encodedValue2 + "%" + hexValue;
                }
            }
        }
        public void Input3()
        {
            Console.WriteLine("https://companyserver.com/content/{0}/files/{1}/{1}Report.pdf", encodedValue, encodedValue2);
        }
    }










    class program
    {
        static void Main(string[] args)
        {
            do
            {
                Url i = new Url();
                i.Input();
                i.Input2();
                i.Input3();
                Console.WriteLine("Play again?(y/n)");
            }
            while (Console.ReadLine().ToLower().Equals("y"));

        }
    }
}