using static System.Int32;
using Console = System.Console;

namespace HomeWorkRegularCustomer
{
    public class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer("Дмитрий");
            var customer1 = new Customer("ЛжеДмитрий");
            var shop = new Shop();
            shop.SubscribeUser(customer);
            shop.SubscribeUser(customer1);
            ConsoleKeyInfo ki;
            do
            {
                
                PrintInstructions();
                ki = Console.ReadKey();
                switch (ki.Key)
                {
                    case ConsoleKey.A:
                        shop.Add();
                        Console.WriteLine();
                        break;
                    case ConsoleKey.D:
                        shop.Remove(ChooseIdItemToDelete(shop));
                        Console.WriteLine();
                        break;
                    case ConsoleKey.S:
                        shop.ShowItems();
                        Console.WriteLine();
                        break;
                }
            } while (ki.Key != ConsoleKey.X);
        }

        private static void PrintInstructions()
        {
            Console.WriteLine("Нажми \"А\", чтобы добавить Item");
            Console.WriteLine("Нажми \"D\", чтобы удалить Item");
            Console.WriteLine("Нажми \"S\", чтобы показать весь список Item в Shop");
            Console.WriteLine("Нажми \"X\", чтобы выйти");
        }
        private static int ChooseIdItemToDelete(Shop shop)
        {
            Console.WriteLine("\nВведи Id Item, который хочешь удалить");
            shop.ShowItems();
            int id;
            try
            {
                TryParse(Console.ReadLine(), out id);
            }
            catch (Exception e)
            {
                Console.WriteLine("Введено не число");
                throw;
            }
            return id;
        }
    }
}