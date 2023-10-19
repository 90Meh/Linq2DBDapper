using Linq2DBDapper;
using Linq2DBDapper.Table;
using LinqToDB;
using LinqToDB.Data;
using static LinqToDB.Reflection.Methods.LinqToDB.Insert;

internal class Program
{
    private static void Main(string[] args)
    {   
        //Вывод всех таблиц по очереди
        List<Customers> customers = LinqRepository.GetCustomers();
       foreach (var customer in customers)
        {
            Console.WriteLine($"{customer.LastName}///{customer.FirstName}");
        }
        List<Orders> orders = LinqRepository.GetOrders();
        foreach (var order in orders)
        {
            Console.WriteLine($"{order.Quantity}///{order.ID}");
        }
        List<Products> products = LinqRepository.GetProducts();
        foreach (var product in products)
        {
            Console.WriteLine($"{product.Name}////{product.Description}");
        }

        //Обращение с поиском по имени
        string n;
        do
        {
            Console.WriteLine("Ведите имя для поиска");
            n = Console.ReadLine();
            foreach (var item in LinqRepository.GetCustomersName(n))
            {
                Console.WriteLine($"{item.FirstName}///{item.LastName}");
            }
            Console.WriteLine("Введите stop для выхода");
        } while (false);

        Console.WriteLine();


        //Через даппер 
        CustomTable customTable = new CustomTable();
        var listT = customTable.GetCustomTables();
        foreach (var item in listT)
        {
            Console.WriteLine($"{item.ID} {item.FirstName}  {item.LastName}  {item.ProductID} {item.Quantity} {item.Price}");
        }
    }  
}