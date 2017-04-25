using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubTest
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("hello git");
            System.Console.WriteLine("문자열 추가");

            new MyClass().Perform();
        }
    }

    class MyClass
    {
        private delegate void RunDelegate(int i);

        private void RunThis(int val)
        {

            Console.WriteLine("{0}", val);
        }

        private void RunThat(int value)
        {
            Console.WriteLine("0x{0:X}", value);
        }

        public void Perform()
        {
            RunDelegate run = new RunDelegate(RunThis);

            run(1024);


            run = RunThat;
            run(1024);
        }
    }

}