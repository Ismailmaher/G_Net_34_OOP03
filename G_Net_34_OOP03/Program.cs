using System.ComponentModel;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;
using System.Security.Principal;

namespace G_Net_34_OOP03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 : Theoretical Questions



            //Q1: Identify the type of relationship in each scenario below(Inheritance, Association, Aggregation, Composition, or Dependency):

            // a) A University has Departments. If the university is closed, the departments no longer exist.
            //         Composition
            // b) A Driver uses a Car.The driver does not own the car.
            //          Association
            // c) A Dog is an Animal.
            //          Inheritance
            // d) A Team has Players. If the team is deleted, the players still exist.
            //          Aggregation
            // e) A method receives a Logger as a parameter and calls it inside the method only.
            //          Dependency

            //======================================================
            //        Q2: Answer the following questions about access modifiers and sealed:
            //a) A parent class has a protected field.Can a child class in a different assembly access it?
            //What about through an object instance from outside?
            //Yes.A child class  can access a protected field of its parent even if it is located in a different assembly
            //No.You cannot access a protected member via an object instance
            //b) What is the difference between protected internal and private protected?
            // protected internal = same assembly OR child anywhere(more open). 
            //private protected = child in same assembly only(more restrictive).

            //c) What does the sealed keyword do when applied to a class? What about when applied to a method?
            //Prevent unsafe overrides and guarantee behavior consistency
           // When applied to a method: It prevents a derived class from further overriding that specific method.

        //d) Can you create an object from a sealed class using new? Why or why not?
      //Yes, Sealed prevents inheritance, not instantiation. You can still create objects.


            #endregion
    }
    }
}
