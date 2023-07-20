using System;

class Program
{
    static void Main(string[] args)
    {
       Console.Clear();
       Address[] addresses = new Address[2];
       Customer[] customers = new Customer[2];
       List<Product>[] productList = new List<Product>[2];
       Order[] orders = new Order[2];

       addresses[0]= new Address("123 Street", "City","State", "USA");
       customers[0] = new Customer("Bob" ,addresses[0]);
       productList[0] = new List<Product>();
       productList[0].Add(new Product("something 1" ,"123qwe",11 ,3 ));
       productList[0].Add(new Product("something 2" ,"345wer",13 ,2 ));
       orders[0] = new Order(customers[0],productList[0]);


        addresses[1]= new Address("345 Street","City","State", "ITALY");
       customers[1] = new Customer("Jeff" ,addresses[1]);
       productList[1] = new List<Product>();
       productList[1].Add(new Product("something 1" ,"123qwe" ,15 ,1 ));
       productList[1].Add(new Product("something 2" ,"345wer" ,8 ,2 ));
       productList[1].Add(new Product("something 3" ,"567rty" ,2 ,3 ));
       orders[1] = new Order(customers[1],productList[1]);

       for (int i = 0; i < 2; i ++)
       {
        Console.WriteLine($"....Customer {i + 1} Order.....");
        Console.WriteLine($"Packing Label: "+
        $"{orders[i].GetPackingLable()}");
        Console.WriteLine($"Shipping Lable: " +
        $"{orders[i].GetShippingLabel()}");
        Console.WriteLine($"Get total cost: "+
        $"{orders[i].GetTotalCost()}");
       }
    }
}