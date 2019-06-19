using System;

namespace Sol_Action_Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Action actionObj=()=> Console.WriteLine("Hello Action");
                actionObj();

            ActionDemo actionDemoObj=new ActionDemo();
                actionDemoObj.ActionParameter(2,2,(leValue1,leValue2)=> Console.WriteLine(leValue1 + leValue2));
                actionDemoObj.ActionParameter(2,3,(leValue1,leValue2)=>{

                    if(leValue1==leValue2){
                        Console.WriteLine("Both the value are the same");
                    }
                    else
                    {
                        Console.WriteLine("Both the value are not same");
                    }

                });

                actionDemoObj.ActionParameter(2,2,actionDemoObj.ActionReturn());
        }
    }

    public class ActionDemo{

        public void ActionParameter(int value1,int value2, Action<int, int> actionOps){

            actionOps(value1,value2);
        }

        public Action<int,int> ActionReturn(){
            return 
                (leValue1,leValue2)=> Console.WriteLine(leValue1 + leValue2);
        }

    }
}
