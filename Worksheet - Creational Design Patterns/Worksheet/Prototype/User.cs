using System.ComponentModel;

namespace QuestionFour
{
    public class User
    {
        public string UserName { get; set; }
        public string Level { get; set; }
        public Access AccessControl { get; set; }
        
        public string userlevel { get; set; }

        public User(string name, string level, AccessControl userAccessControl)
        {
            UserName = name;
            Level = level;
            AccessControl = userAccessControl.Access;
            userlevel = userAccessControl.userlevel;

        }

        public override string ToString()
        {
            return $"Name: {UserName}, Level: {Level}, Access Control Level: {userlevel}, Access: {AccessControl}";
        }  

    }
}