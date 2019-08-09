using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Text;


namespace Server.Lib
{
    
    class ApiHandler
    {
        string[] targetClasses;
        public ApiHandler()
        {
            targetClasses = new string[3];
            targetClasses[0] = "Server.Controllers.UserController";
            targetClasses[1] = "Server.Controllers.BankAccountController";
            targetClasses[2] = "Server.Controllers.BillController";
        }

        public string handle(string command)
        {
            object[] route = router(command);

            string targetClass = (string) route[0];
            string targetMethod = (string) route[1];
            object[] payload = (object[]) route[2];

            if (!targetClasses.Contains(targetClass))
                return "class_not_found";
            
            object obj = Assembly.GetExecutingAssembly().CreateInstance(targetClass);
            
            MethodInfo theMethod = obj.GetType().GetMethod(targetMethod);
            var result = theMethod.Invoke(obj, payload);

            return (string) result;
        }

        private object[] router(string command)
        {
            string[] protocol = command.Split('#');
            string targetClass = "Server.Controllers." + protocol[0] + "Controller";
            string targetMethod = protocol[1];
            object[] payload = new object[protocol.Length - 3];
            
            for(int i=2; i < protocol.Length-1; i++)
            {
                payload[i - 2] = protocol[i];
            }

            return new object[] { targetClass, targetMethod, payload };
        }
    }
}