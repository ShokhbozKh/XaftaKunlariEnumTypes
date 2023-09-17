using System.Diagnostics.SymbolStore;

namespace ConsoleApp2
{
    enum LanguageType 
    {
        Dushanba=1,
        Seshanba,
        Chorshanba,
        Payshanba,
        Juma,
        Shanba,
        Yakshanba

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Xafta kunini kiriting:");
                int number = int.Parse(Console.ReadLine());
                LanguageType language = (LanguageType)number;

                if (number > 0 && number < 6)
                {
                    Console.Clear();
                    Console.WriteLine($"bugun ish kuni:{language}");

                }
                else if (number == 6 || number == 7)
                {
                    Console.Clear();
                    Console.WriteLine($"Dam olish kuni: {language}");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("xatolik bor");
                }

                
                Main(args);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Xatolik bor: {ex.Message}");
            }
            

        }
    }
}