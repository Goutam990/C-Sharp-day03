using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace C_Sharp_oops
{
     
            //Encapuslation + Abstraction(public data members + public methods)
            class MyclassEncapsulation_Abstraction {
             
            private string name = "Goutam";
             
             // public method to access the private data variable

             public string Getname()
        {
                return name;
        }

             public void Setname(string name)
            { this.name = name; }

               public void testingmethod()
            {
                Console.WriteLine("Hello i am under a class");
            }    
            }
    
            // public Access modifier example  - ( Abstraction - public ) 
            public class car1
    {
        public string carModel = "Brezza"; // Accessible from anywhere.
    }

    public class car2 : car1
    {
        public string GetcarModel()
        {
            return carModel;
        }
    }

    //private Access Modifier example - (Abstraction - private)
    public class car3
    {
        public string Engine_Serial_No = "Mp43423u"; // Top secret

        //within the car1 class -- we have methods
        public void printEng_Serial_No()
        {
           Console.WriteLine(Engine_Serial_No); // Within the class -- Accessible h  
        }
    }

    //outside of the class -- private members ---> not accessible
    public class car4 : car3
    {
        public string getSerialNo()
        {
            return Engine_Serial_No; // subclass can not access the private members defined in   base class
        }
    }

    //==========================================
    //protected Access Modifier example --
    public class car5
    {
        public string car_designCode = "579345857340"; // Family secret.

        
        public string printCar_designCode()
        {
            return car_designCode; // Within the class -- To accessible h hi   
        }
    }

    //outside of the class -- protected members --->  are accessible
    public class car6 : car5
    {
        public string printCar_designCodeo()
        {
            return car_designCode; // protected members can be accessed by the sub-class also.
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Oops 
            // oops provides us a way to organize our code using classes. 
            // 4 piller of oops are - Abstraction, Inheritance, Polymorphism , Encapusultaion. 
            MyclassEncapsulation_Abstraction myclass = new MyclassEncapsulation_Abstraction();
            myclass.testingmethod();

            myclass.Setname("Arusha");
            string returnedName = myclass.Getname();
            Console.WriteLine(returnedName);

            // 1. Abstraction 
            // using assess modifier -- public , protected , private
            // another example of abstraction is in the backend . (somewhat complicated )
            //for now Abstraction only means to us by access modifiers. 

            //public access modifier - 
            // anywhere accessible -- class , sub class, another can access the data members having public modifier infront of them 

            //================================public access modifier example ================
            // creating an object of subclass nd trying to acccess public data members. 

            car2 c2 = new car2();
            string returned_carModel = c2.GetcarModel();
            Console.WriteLine(returned_carModel);


            //==================================private access modifier example================
            //car4 c4 = new car4();
           // string returned_Eng_SNo = c4.printEng_Serial_No(); // cannot access the private members here -- (Serial No - is a private member of c3 class)
            //Console.WriteLine (returned_Eng_SNo);


            //==================================protected access modifier example==============
            car6 car6 = new car6();
            string returend_DesignCode = car6.printCar_designCode();
            Console.WriteLine(returend_DesignCode);




            


        }
    }
}
