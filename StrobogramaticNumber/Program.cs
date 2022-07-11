namespace StrobogramaticNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, char> strobogramaticsPairs = new Dictionary<char, char>();

            strobogramaticsPairs.Add('0', '0');
            strobogramaticsPairs.Add('1', '1');
            strobogramaticsPairs.Add('2', '2');
            strobogramaticsPairs.Add('5', '5');
            strobogramaticsPairs.Add('6', '9');
            strobogramaticsPairs.Add('8', '8');
            strobogramaticsPairs.Add('9', '6');

            Console.WriteLine("Podaj liczbę do sprawdzenia, czy jest liczbą strobogramatyczną:\r\n");
            ulong number;
            UInt64.TryParse(Console.ReadLine(), out number);

            int numberLengthMod = number.ToString().Length % 2;
            bool isStrobogramatic = true;

            if (numberLengthMod == 0)
            {
                for (int i = 0; i < number.ToString().Length / 2; i++)
                {
                    if (number.ToString()[number.ToString().Length - i - 1] != strobogramaticsPairs[number.ToString()[i]])
                    {
                        isStrobogramatic = false;
                        break;
                    }
                }
            }
            else
            {
                if (number.ToString()[number.ToString().Length / 2] != 0 || number.ToString()[number.ToString().Length / 2] != 1 ||
                    number.ToString()[number.ToString().Length / 2] != 8)
                    isStrobogramatic = false;
                else
                {
                    for (int i = 0; i < number.ToString().Length / 2 - 1; i++)
                    {
                        if (number.ToString()[number.ToString().Length - i - 1] != strobogramaticsPairs[number.ToString()[i]])
                        {
                            isStrobogramatic = false;
                            break;
                        }
                    }
                }
            }
            if (isStrobogramatic)
                Console.WriteLine($" Liczba {number} jest liczbą strobogramatyczną.");
            else
                Console.WriteLine($" Liczba {number} nie jest liczbą strobogramatyczną.");
        }
    }
}