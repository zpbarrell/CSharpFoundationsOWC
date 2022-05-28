using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KomodoGreeting.Repository
{
    public class Greeting
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public StatusType? StatusType { get; set; }
        public string Email { get; set; }

        public Greeting(string firstName, string lastName, StatusType? statusType, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            StatusType = statusType;
            Email = email;
        }

        // public Greeting(string firstName, string lastName)
        // {
        //     FirstName = firstName;
        //     LastName = lastName;
        // }
    }
    public enum StatusType { Current, Potential, Past }
}