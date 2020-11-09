using System;
using System.ComponentModel;
using System.Threading.Channels;

namespace QuestionFour
{
    public static class AccessControlProvider
    {
        private static AccessControl UserLevel = new AccessControl();
        private static AccessControl ManagerLevel = new AccessControl();
        private static AccessControl AdminLevel = new AccessControl();
        public static AccessControl GetAccessControlObject(string controlLevel) {
            
            string n_item = controlLevel;
            switch (n_item)
            {
                case "USER":
                    var a = UserLevel.Clone();
                    a.Access = Access.DO_WORK;
                    a.userlevel = "USER"; ;
                    return a;
                
                case "MANAGER":
                    var b = ManagerLevel.Clone();
                    b.Access = Access.GENERATE_READ_REPORTS;
                    b.userlevel = "MANAGER";
                    return b;
                
                case "ADMIN" :
                    var c = AdminLevel.Clone();
                    c.Access = Access.GENERATE_READ_REPORTS;
                    c.userlevel = "ADMIN";
                    return c;

                default:
                    Console.WriteLine("No match found");
                    break;
            };
            return null;
        }
    }
}