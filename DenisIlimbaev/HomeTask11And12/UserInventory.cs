using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask11
{
    class UserInventory<TProduct> where TProduct : RefProduct
    {
        internal Inventory<TProduct> UserInv {  get; private set; }
        internal string[] arrayCategory {  get; private set; } =
        {
            "Еда",
            "Косметика"
        };
        internal UserInventory(Inventory<TProduct> inventory)
        {
            UserInv = inventory;
        }

        internal void Start()
        {
               
            string[] actions = 
            {
                "1.Добавить продукт",
                "2.Удалить продукт по ID",
                "3.Вывести список всех продуктов",
                "4.Получить сумму всех продуктов"
            };
            Console.WriteLine("Выберите действие: ");
            
            foreach(string action in actions ) Console.WriteLine(action);
            switch (Convert.ToUInt32(Console.ReadLine()))
            {
                case 1:
                    Product product = new Product()
                    {
                        NameProduct = Input("Введите название продукта: "),
                        Quantity = Convert.ToUInt32(Input("Введите количество продукта: ")),
                        Price = Convert.ToUInt32(Input("Введите цену на продукт: "))
                    };
                    UserInv.AddProductInInventory((TProduct)new RefProduct() { ProductObj = product});
                    break;
                case 2:
                    UserInv.DeletedProductInInventory(Input("Введите ID продукта: "));
                break;
                case 3:
                    UserInv.AllProductInInventory();
                break;
                case 4:
                    Console.WriteLine($"цена корзины на текущий момент: {UserInv.PriceInventory()}");
                    break;
                default:
                    Console.WriteLine("unknown action");
                    break;

            }

        }
        private string Input(string message)
        {
            Console.Write(message);
            return Console.ReadLine() ?? throw new NullReferenceException();
        }
        private CategoryProduct TakeMeCategory()
        {
            for(int i = 0; i < arrayCategory.Length; i++) Console.WriteLine($"{i}.{arrayCategory[i]}");
            Console.Write("Выберите категорию: ");
            uint j = Convert.ToUInt32(Console.ReadLine());
            return (CategoryProduct) ((j <= arrayCategory.Length) ? j : throw new Exception());
        }
         
    }
}
