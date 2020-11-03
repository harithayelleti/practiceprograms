using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designpatterns
{
    class AbstractFactoryDP  //Super Class
    {
        public class Client  //Abstract Factory :Class uses the abstract factory and abstract
                                                  //Product to create a family related to objects
        {
            //Creating Abstract Product and Factory
            private AbstractProductA _productA; //Class ==> Abstract Product A where abstract class should present
            private AbstractProductB _productB; //Class ==> Abstract Product B where abstract class should present

            public Client(AbstractFactory factory) //factory==>parameter
            {
                _productA = factory.CreateProductA(); //Object created for the class  Abstract ProductA //Intantiated with class AbstractProductA
                _productB = factory.CreateProductB(); //Intantiated with class AbstractProductB //By using Parameter we have instantiated class where CreateProductA();and  CreateProductB(); are the methods

            }

        }

        public abstract class AbstractFactory  
        {
            public abstract AbstractProductA CreateProductA();   //Globalizing  the abstract class with instance created
            public abstract AbstractProductB CreateProductB();   //Globalizing  the abstract class with instance created


        }

        public class ConcreteFactoryA : AbstractFactory //implementing the abstract Factory Interface
        {
            public override AbstractProductA CreateProductA() //Instance Method: Created ProductA
            {
                return new ProductA1();
            }

            public override AbstractProductB CreateProductB() //Instance Method: Created ProductA
            {
                return new ProductB1();
            }
        }
            public class ConcreteFactoryB : AbstractFactory //implementing the abstract Factory Interface
            {
                public override AbstractProductA CreateProductA() //Instance Method: Created ProductA
                {
                    return new ProductA1();
                }

                public override AbstractProductB CreateProductB() //Instance Method: Created ProductA
                {
                    return new ProductB1();
                }
            }
        public abstract class AbstractProductA { } //Invoking the class w.r.t Instance  created
        public class ProductA1 : AbstractProductA { }
        public class ProductA2 : AbstractProductA { }
        public abstract class AbstractProductB { }  //Invoking the class w.r.t Instance  created
        public class ProductB1 : AbstractProductB { }
        public class ProductB2 : AbstractProductB { }





        static void Main(string[] args)
        {
        

        }
    }
}
