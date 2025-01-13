namespace ssn_grupp8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string numb = "8907163570";

            if (string.IsNullOrWhiteSpace(numb) || numb.Length != 10 || !numb.All(char.IsDigit))
            {
                Console.WriteLine("Ogitligt format, endast number och 10 siffro");
            }
            else
            {
                Console.WriteLine("Korrekt inmatning");
            }

            int[] intnumb = new int[10];
            for (int i = 0; i < 10; i++)
            {
                intnumb[i] = numb[i] - '0';
            }

            int sum = 0;

            for (int i = 0; i < 9; i++)
            {
                int value = intnumb[i];
                if (i % 2 == 0)
                {
                    value *= 2;
                    if (value > 9)
                    {
                        value -= 9;
                    }
                }
                sum += value;
            }
            int ssnControllDigit = (10 -(sum % 10)) % 10;

            if (ssnControllDigit == intnumb[9])
            {
                Console.WriteLine($"Personnummret är gigligt, kontrollsiffra: {ssnControllDigit}");
            }
            else
            {
                Console.WriteLine($"Personnumret ör ogiligt! Kontrollsiffra borde vara {ssnControllDigit}, men är {intnumb[9]}.");
            }


        }
    }
}
