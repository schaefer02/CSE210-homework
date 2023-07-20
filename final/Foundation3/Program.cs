using System;

class Program
{
    static void Main(string[] args)
    {
        Address[] addresses = new Address[3];
        addresses[0] = new Address("123 main", "city1","state1","23681","USA");
        addresses[1] = new Address("234 main", "city2","state2","23682","USA");
        addresses[2] = new Address("345 main", "city3","state3","23683","USA");

        Event[] events = new Event[3];
        events[0] = new Lecture("Lecture talk","Talk about Lecture","1/1/11","15:00",addresses[0],"Bob","100 people");
        events[1] = new Reception("Reception","Talking with others","2/2/22","1600",addresses[1],"Reception@gmail.com");
        events[2] = new Outdoor("Talking in Park","Alot of talking in the park","3/3/23","1700",addresses[2],"Tornadoes");

        for (int i =0; i< 3; i++)
        {
            Console.WriteLine($"Event: {i + 1}");
            Console.WriteLine("\n ...Details...");
            Console.WriteLine(events[i].Details());
            Console.WriteLine("...Overview...");
            Console.WriteLine(events[i].ShortDetails());
            Console.WriteLine("...Full Details...");
            Console.WriteLine(events[i].CompleteDetails());
        }
    }
}