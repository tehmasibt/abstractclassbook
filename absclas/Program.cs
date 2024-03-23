using absclas.Model;

namespace absclas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Account account = new Account();
            //account.Login("Admin", "AdminEA18yr@"); // task-1

            string number;
            int massiveLength;
            do
            {
                Console.Write("Enter array length:");
                number = Console.ReadLine();

            } while (!int.TryParse(number, out massiveLength));

            Book[] books = new Book[massiveLength];
            
            for (int i = 0; i < books.Length; i++)
            {
                string takeNo;
                int no;
                do
                {
                    Console.WriteLine("No daxil edin:");
                    takeNo = Console.ReadLine();

                } while (!int.TryParse(takeNo, out no));

                string name;
                do
                {
                    Console.WriteLine("Enter book name: ");
                    name = Console.ReadLine();

                } while (string.IsNullOrEmpty(name));

                int price;
                string takePrice;
                do
                {
                    Console.WriteLine("Enter book price:");
                    takePrice = Console.ReadLine();

                } while (!int.TryParse(takePrice, out price));

                string genre;
                do
                {
                    Console.WriteLine("Enter book genre: ");
                    genre = Console.ReadLine();

                } while (string.IsNullOrEmpty(genre));

                Book book = new Book(genre,no,name,price);
                book.Id = no;
                book.Name = name;
                book.Price = price;
                book.Genre = genre;

                books[i] = book;
            }

            foreach (Book book in books)
            {
                Console.WriteLine($"No:{book.Id} Name:{book.Name} Price:{book.Price}  Genre:{book.Genre}");
            }
        }
       
    }
}
