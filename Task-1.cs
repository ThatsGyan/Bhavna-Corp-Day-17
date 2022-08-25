// See https://aka.ms/new-console-template for more information





//Checking Armstrong Number//

int Number = 153;
int rem;

int Cube;
int Result = 0;
int temp  = Number;
while(Number!=0)
{
    rem = Number % 10;
    Cube = rem * rem * rem;
    Result = Result + Cube;

    Number /= 10;
}
Number = temp;
if(Number==Result)
{
    Console.WriteLine("Yes It is a armstrong Number");
}
else
{
    Console.WriteLine("No ! It is not a armstrong Number");
}



//Concatenate Strings//

string first = "Hi ..!,How are you";
string second = " Where are you from";

Console.WriteLine(String.Concat(first, second));

// Polymorphism // 
//Method over loading//

namespace MethodOverloading
{

    class Program
    {
        void Sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        void Sum(float a, float b)
        {
            Console.WriteLine(a * b);
        }

        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.Sum(20.2f, 30.33f);
            Console.ReadLine();
        }

    }

}

//Mothod overRiding//

namespace MethodOverriding

{
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine(" Animal is Eating");
        }

    }
    class Dog :Animal
    {
        public void Eat()
        {
            Console.WriteLine(" Dog is Eating");
        }
        public static void Main(string[] args)
        {
            Dog tommy = new Dog();
            tommy.Eat();
        }
    }
}



