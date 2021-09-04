using ObservablePattern.Concrete;
using System;

namespace ObservablePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Publisher publisher = new Publisher();

            Subscriber subscriber1 = new Subscriber(publisher);
            Subscriber subscriber2 = new Subscriber(publisher);
            Subscriber subscriber3 = new Subscriber(publisher);
            Subscriber subscriber4 = new Subscriber(publisher);
            Subscriber subscriber5 = new Subscriber(publisher);

            publisher.ChangeEdition();
            publisher.ChangeEdition();

            Console.ReadKey();
        }
    }
}
