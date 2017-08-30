namespace Module04_ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            PersonStruct p1;
            p1.Id = 1;

            PersonStruct p2 = new PersonStruct();
            p2.Id = 2;

            System.Console.WriteLine("p1 :" + p1.Id);
            System.Console.WriteLine("p2 :" + p2.Id);

            p1 = p2; //kopier værdier

            System.Console.WriteLine("p1 :" + p1.Id);
            System.Console.WriteLine("p2 :" + p2.Id);

            p2.Id = 20;

            System.Console.WriteLine("p1 :" + p1.Id);
            System.Console.WriteLine("p2 :" + p2.Id);

            PersonClass p3 = new PersonClass();
            p3.Id = 3;

            PersonClass p4 = new PersonClass();
            p4.Id = 4;

            System.Console.WriteLine("p3 :" + p3.Id);
            System.Console.WriteLine("p4 :" + p4.Id);

            p3 = p4; // sætter reference lige hinanden

            // p3 structuren i heap er nu væk og bliver spist af garbage collector på et tidspunkt og den er væk for altid i heap

            System.Console.WriteLine("p3 :" + p3.Id);
            System.Console.WriteLine("p4 :" + p4.Id);

            p4.Id = 20;

            System.Console.WriteLine("p3 :" + p3.Id);
            System.Console.WriteLine("p4 :" + p4.Id);

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
    // struct ligger i stack
    struct PersonStruct
    {
        public int Id;
    }
    // class ligger i heap
    class PersonClass
    {
        public int Id;
    }
        
}

