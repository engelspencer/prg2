using System;
using prg2._1_intro;
using prg2._2_oop;
using prg2._3_design_patterns;
using prg2._4_functional_programming;
using prg2._5_database_design;


namespace _0_main
{
    class Program
    {
        static void Main(string[] args)
        {
            Select.run();
            Console.ReadKey();
        }

        static void test(string [] args)
        {
            Intro i = new Intro(args);
            OOP o = new OOP(args);
            Design_Patterns d = new Design_Patterns(args);
            Functional_Programming f = new Functional_Programming(args);
            Database_Design dd = new Database_Design(args);
        }

        /*
        static void NodeTest()
        {
            Console.WriteLine("I'm testing Node.");
            string done = "";
            Node<int> linkedList = new Node<int>(0);
            Node<int> root = linkedList;
            while(done != "y")
            {
                Console.WriteLine("Insert an integer for Linked List");
                int value = Convert.ToInt32(Console.ReadLine());
                linkedList.next = new Node<int>(value, root);
                linkedList = linkedList.next;
                Console.WriteLine("Are you done adding y/n");
                done = Console.ReadLine().ToLower();
            }
            linkedList.Print();
            linkedList.PrintAll();
        }
        */

        static void CoffeeTest()
        {
            CoffeeMaker lifesaver = new CoffeeMaker();
        }
    }
}
