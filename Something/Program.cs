using System;
using System.Linq;

namespace Something
{
    class Program
    {
        static void Main(string[] args)
        {
            var myList = new MyList();
            var array = myList.ToArray();
            foreach (var n in myList)
            {
                Console.WriteLine(n);
            }
        }
        static void Main2(string[] args)
        {
            var screenWriter = new ConsoleScreenWriter();
            var component = new Component(5, 2, 20, 4, screenWriter);
            component.Show();

            var label = new Label(10, 10, "Terje", screenWriter);
            label.Show();
        }
    }
}
