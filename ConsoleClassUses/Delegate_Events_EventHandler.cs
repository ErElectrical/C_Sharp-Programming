using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClassUses
{



    //In simple words, we can say that the delegates in C# are the Type-Safe Function Pointer.
    //It means they hold the reference of a method or function and then call that method for execution.

    //Delegate is basically a pipeline which takes data when event genrated and eventhandler(callback func) recieve it
    //it is created by using delegate keyword
    //Delegate signature , acess modifier , return type , order of parameter should be matched with event handler
    //otherwise event handler could not recieve data from pipeLine 

    //Multicast Delegate is a way to hold multiple delegates. For example,
    //I have one message that I want to send over multiple pipelines which will dump the same data into multiple Handler Methods.
    //So, your custom delegate as we discussed earlier will inherit from the Multicast Delegate

    public enum WorkType
    {
        Golf,
        GotoMeetings,
        GenerateReports
    }

    //Step 1 : Declear the delegate .
    public delegate void workperformed(int number, WorkType work);

    public delegate void CallbackMethodHandler(string message);


    public class Delegate_Events_EventHandler
    {

        

       


        //Declare the event handler with same signature
        public static  void Mangage_workperformed(int number , WorkType work)
        {
            Console.WriteLine($"Delegate Called :  {number}");
            Console.WriteLine($"Delegate Called :  {work}");
        }

        //creating a instance of Delgate 
        //If Event handler (Method ) is static than it can be automatically called
        //but if it is non- static than an method should be provivded by object creation

        public static void DoSomework(CallbackMethodHandler del)
        {
            Console.WriteLine("Processing some Task");
            del("Pranaya");
        }
        public  void CallbackMethod(string message)
        {
            Console.WriteLine("CallbackMethod Executed");
            Console.WriteLine($"Hello: {message}, Good Morning");
        }

        public static void InvokeDelegate()
        {

            workperformed wll = new workperformed(Mangage_workperformed);

            //How to invoke the Delegate

            workperformed del1 =
                            new workperformed(Mangage_workperformed);
            //del1(10, WorkType.Golf);
            //del1.Invoke(50, WorkType.GotoMeetings);

            del1(23, WorkType.GenerateReports);


            Console.WriteLine("Delegates are used to invoke the call-back functions." +
                " What it means is we will invoke one function and we will pass the delegate instance as a parameter " +
                "to that function and we expect that function to invoke the delegate at some point of time which will invoke" +
                " the callback method referred by the delegate instance.");

            Delegate_Events_EventHandler obj = new Delegate_Events_EventHandler();

            CallbackMethodHandler wll1 = new CallbackMethodHandler(obj.CallbackMethod);

            DoSomework(wll1);


        }
    }
}
