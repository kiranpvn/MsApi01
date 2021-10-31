namespace ConApp01
{
    static class MyExtensions
    {
        public static int Next(this int n)
        {
            return n+1;
        }
        public static int Factorial(this int n)
        {
            int f = 1;
            for (int i = n; i > 1; i--)
                f *= i;
            return f;
        }
    }
}

// F5:          Debug
//Coffe break: Session resume at 11:15am

// Shift+F5:    Stop Debug
//Ctrl+F5   :   Run the project


/*StudentBO context = new StudentBO();

            int ch = 0;
            do
            {
                Console.Write("Menu\n1.Display All\n2.Search\n3.Add\n4.Edit\n5.Delete\n6.Exit\nEnter Choice: ");
                ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        foreach ( StudentModel s in context.GetAllStudents())
                            Console.WriteLine($"{s.Id} {s.SName} {s.Course} {s.Fee}");
                        break;
                    case 2:
                        {
                            Console.Write("Enter id: ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            StudentModel s = context.GetStudentById(id);
                            if (s is null)
                                Console.WriteLine($"{id} not exist");
                            else
                                Console.WriteLine($"{s.Id} {s.SName} {s.Course} {s.Fee}");
                        }
                        break;
                }
            } while (ch!=6);                      */