using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chpt14Enum_ClassTshirt // ADD new tab : Solution Explorer, Right click the c#box, Add, New Item
{   // You work at a T-shirt shop. You have T-Shirts with the following attributes:
    // *Colors: Red, Green, Blue. Sizes: XL = 4, L= 3, M= 2, S= 1
    //*Create the structures for theses constant values. *Create Classes for t-shirts,allowing color and size.
    //*Simulate 3 Customers ordering t-shirts of a certain color and size.*Print out what they ordered as number size&color.
    //*Defalt Value: red, Medium (Constructor) 
    class Program   // How to Create a Class 
    {
        static void Main(string[] args)
        {
            TShirt order1 = new TShirt(TshirtSize.S,TshirtColor.Blue);
            TShirt order2 = new TShirt(TshirtSize.L,TshirtColor.Green);
            TShirt default9 = new TShirt();


            //TShirt mediumTShirt = new TShirt(TShirt.M);

            Console.WriteLine("The T-shirt is size {0} and the color is {1}.", // The Normal coffee is 150 ml
            (int)order1.Size, order1.Color);
            Console.WriteLine("The T-shirt is size {0} and the color is {1}.",
            (int)default9.Size, default9.Color);
            Console.WriteLine("The T-shirt is size {0} and the color is {1}.", // The Normal coffee is 150 ml
            (int)order2.Size, order2.Color);
            //Console.WriteLine("The {0} coffee is {1} ml.",// The Double coffee is 300 ml
            //.Size, (int)doubleCoffee.Size);

        }
        
        }
    }



       
    

