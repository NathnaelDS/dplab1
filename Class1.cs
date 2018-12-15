using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


delegate int Operation(int n);
namespace DPProjects
{
    // VIRTUAL AND OVERRIDING, 
    // AND ALSO PROPERTIES
    class BaseClass
    {
        public virtual string Name { get; set; }

        private int age;
        public virtual int Age
        {
            get { return age; }
            set { age = value; }
        }
    }

    class DerivedClass : BaseClass
    {
        private string name;
        public override string Name
        {
            
            get
            {
                return name;
            }

            set
            {
                if (value != String.Empty)
                {
                    name = value;

                }
                else
                {
                    name = "unknown";
                }
            }
        }
    }

    // DELEGATION
    class Delegation
    {
        static int num = 10;

        public static int AddNum(int p)
        {
            num += p;
            return num;
        }
        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }
        public static int getNum()
        {
            return num;
        }
        static void Main(string[] args)
        {
            //create delegate instances
            Operation op1 = new Operation(AddNum);
            Operation op2 = new Operation(MultNum);

            //calling the methods using the delegate objects
            op1(25);
            Console.WriteLine($"Value of Num: {getNum()}");
            op2(5);
            Console.WriteLine($"Value of Num: {getNum()}");
            //Console.ReadKey();
        }
    }
    // ARRAY OF INTERFACE TYPES (FOR RUNNING POLYMORPHISM)
    public interface ISides
    {
        byte GetNumberOfSides();
        void Draw();
    }
    public class Hexagon : ISides
    {
        public Hexagon() { }
        public Hexagon(string name) { }
        public byte GetNumberOfSides()
        {
            return 6;
        }
        public void Draw()
        {
            Console.WriteLine("Drawing Hexagon");
        }

    }
    public class Rectangle : ISides
    {
        public Rectangle() { }
        public Rectangle(string name) { }
        public byte GetNumberOfSides()
        {
            return 4;
        }
        public void Draw()
        {
            Console.WriteLine("Drawing Rectangle");
        }

    }
    class ArrayOfInterface
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demonstrating arrays of interfaces");
            ISides[] arrayOfInterfaceObj = { new Rectangle("Rectangle1"), new Hexagon("Hexagon1"), new Rectangle() };
            int i = 0;
            foreach (ISides I in arrayOfInterfaceObj)
            {
                I.Draw();
                Console.WriteLine("Number of Points are {0}\n", I.GetNumberOfSides());
            }

            Console.ReadLine();
        }
    }

}
