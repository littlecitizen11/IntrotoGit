using System;

namespace ConsoleApp1
{

    class Program
    {


        public class Programmer
        {
            public Programmer()
            {
                Console.WriteLine("I'm a programmer, I know HTML I'm so cool");
            }

            public virtual void Code()
            {
                Console.WriteLine("I Write " + TypeOfCode);
            }

            public virtual string TypeOfCode
            {
                get { return "HTML"; }
            }
        }

        public class LittleCitizen : Programmer
        {
            public LittleCitizen()
            {
                Console.WriteLine("I'm the little citizen, We have no pension ");
            }

            public override void Code()
            {
                Console.WriteLine("I code " + TypeOfCode);
            }

            public override string TypeOfCode
            {
                get { return "Everything"; }
            }
        }

        public class Commander : LittleCitizen
        {
            public Commander()
            {
                Console.WriteLine("...");
            }

            public new void Code()
            {
                Console.WriteLine("What I know is " + TypeOfCode);
            }

            public override string TypeOfCode
            {
                get
                {
                    return "Irrelevant";
                }
            }
        }

        static void Main(string[] args)
        {
            Programmer programmer = new Programmer();
            programmer.Code();

            Commander commander = new Commander();
            commander.Code();

            LittleCitizen littleCitizen = new LittleCitizen();
            littleCitizen.Code();

            ((Programmer)commander).Code();
            (commander as Programmer).Code();
        }
    }

}
