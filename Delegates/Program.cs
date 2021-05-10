using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter The Word : ");
            string word = Console.ReadLine();
            MyClass myClass = new MyClass();
            Func funcDell = new Func(myClass.Reverse);
            funcDell += myClass.Space;
            Run run = new Run();
            run.RunFunc(funcDell, word);


        }
    }
}
