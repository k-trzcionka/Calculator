using System;


namespace Calculator
{
    public class Operations
    {
        public Operations(double num1, double num2)
        {
            Num1 = num1;
            Num2 = num2;
        }
        public Operations(double num1)
        {
            Num1 = num1;
        }

        public double Num1 { get; set; }
        public double Num2 { get; set; }

        public double AddNumbers()
        {
            return Num1 + Num2;
        }
        public double SubtractNumbers()
        {
            return Num1 - Num2;
        }
        public double MultiplicateNumbers()
        {
            return Num1 * Num2;
        }
        public double DivideNumbers()
        {
            double divide;


            while (Num2 == 0)
            {
                Console.WriteLine("Nie dzielimy przez 0! Proszę spróbować ponownie");
                break;
            }
            divide = Num1 / Num2;


            return divide;

        }
        public string IsNumberEven()
        {
            string isEven;
            if (Num1 % 2 == 0)
            {
                isEven = "Podana liczba jest parzysta";
            } else isEven = "Podana liczba jest nieparzysta";
            return isEven;
        }
    }
}
