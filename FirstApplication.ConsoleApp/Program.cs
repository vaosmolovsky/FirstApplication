using Microsoft.VisualBasic;

namespace FirstApplication.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
            
        {
            Console.WriteLine("Как Вас зовут?");
            string name = Console.ReadLine();
            Console.WriteLine("Здравствуйте, {0}", name);
            Console.WriteLine("Сколько Вам лет?");
            string Birthday = Console.ReadLine();
            Console.WriteLine("В {0} вы еще можете овладеть программированием! Никогда не поздно начинать", Birthday);
            Console.WriteLine("Кем вы сейчас работаете?");
            string work = Console.ReadLine();
            Console.WriteLine("Интересно, в потоке есть еще {0}?", work);
            Console.WriteLine("И так, коротко о вас. Вас зовут {0}, вам {1} лет, вы занимаете должность {2}", name,Birthday,work);

            const int year = 2023;
         //   int Birthday;
            Console.WriteLine("Сейчас {0} год на дворе", year);
            
              

            // int years = year - Birthday; 
            //Console.WriteLine()

        }
    }
}


