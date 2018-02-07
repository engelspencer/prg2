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
            Console.WriteLine("Launching main.");

            prg2._2_oop.hw2 hw = new prg2._2_oop.hw2();
            hw2.LeapYears();
            

            Intro i = new Intro(args);
            //test(args);
          
            Console.ReadKey();
            /*
            To add a project, first add a new folder naming it the [projectname]
            then type 
            dotnet new classlib -o [projectname]
            then cd to 0_main and type
            dotnet add reference ../[projectname]/[projectname].csproj
            */
        
        }
        static void test(string [] args)
        {
            Intro i = new Intro(args);
            OOP o = new OOP(args);
            Design_Patterns d = new Design_Patterns(args);
            Functional_Programming f = new Functional_Programming(args);
            Database_Design dd = new Database_Design(args);
        }

    }
}
