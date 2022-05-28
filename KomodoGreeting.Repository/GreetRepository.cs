using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KomodoGreeting.Repository
{
    public class GreetRepository
    {
        List<Greeting> _greetDB = new List<Greeting>();
        public void AddContactToDatabase(Greeting contact)
        {
            _greetDB.Add(contact);
        }
        public List<Greeting> GetAllContacts()
        {
            return _greetDB;
        }
        //email selection
        string currentCustomer = "We appreciate your loyalty through these hard times. We exist only to serve you.";
        string potentialCustomer = "Its time for you to switch to Komodo Insurance. We have the lowest premiums in the multiverse!";
        string pastCustomer = "We miss you! Take a look at these great promotions, JUST FOR YOU!";
        public string EmailSelectionSwitchCase(StatusType statusType)
        {
            switch(statusType)
            {
                case StatusType.Current:
                    return currentCustomer;
                case StatusType.Potential:
                    return potentialCustomer;
                case StatusType.Past:
                    return pastCustomer;
                default:
                    return potentialCustomer;
            }
        }
        public string GetEmailByCustomerStatus(string customerStatus)
        {
            if(customerStatus == StatusType.Current.ToString())
            {
                return currentCustomer;
            }
            else if(customerStatus == StatusType.Potential.ToString())
            {
                return potentialCustomer;
            }
            else if(customerStatus == StatusType.Past.ToString())
            {
                return pastCustomer;
            }
            else{
                return null;
            }
        }
        public string ChangeUserInputToString(string userStatusSelection)
        {
            switch(userStatusSelection)
            {
                case "1":
                    return "Current";
                case "2": 
                    return "Potential";
                case "3":
                    return "Past";
                default:
                    return "Potential";
            }
        }
        public List<Greeting> GetContactByType(string statusSelection)
        {
            List<Greeting> newContact = new List<Greeting>();
            foreach(Greeting x in _greetDB)
            {
                string customerType = x.StatusType.ToString();
                if(customerType == statusSelection)
                {
                    newContact.Add(x);
                }
                else{
                    return null;
                }
            }
            return newContact;
        }
        //Update
        //DELETE
        public Greeting GetContactByLastName(string lastName)
        {
            foreach(Greeting x in _greetDB)
            {
                if(lastName == x.LastName)
                {
                    return x;
                }
            }
            return null;
        }
        public bool DeleteContactFromDatabase(Greeting contact)
        {
            int totalContactsInDatabase = _greetDB.Count();
            _greetDB.Remove(contact);
            if(totalContactsInDatabase == _greetDB.Count())
            {
                return false;
            }
            return true;
        }
        //MainMenu
        public void PrintMainMenu()
        {
            Console.WriteLine("1. New Contact Entry.\n" + "2. View All Contacts.\n" + "3. View Contacts By Customer Status.\n" + "4. Update A Contact.\n" + "5. Delete A Contact.\n" + "6. Exit.\n");
        }
        public string GetUserInput()
        {
            return Console.ReadLine();
        }
        //SEED DATA
        public void SeedCustomerData()
        {
            Greeting one = new Greeting("Robert", "Downey", StatusType.Potential, "Potential");
            Greeting two = new Greeting("Chrisopher", "Evans", StatusType.Current, "Current");
            Greeting three = new Greeting("Christopher", "Hemsworth", StatusType.Potential, "Potential");
            Greeting four = new Greeting("Mark", "Ruffalo", StatusType.Potential, "Potential");
            Greeting five = new Greeting("Scarlett", "Johnasson", StatusType.Past, "Past");
            Greeting six = new Greeting("Jeremy", "Renner", StatusType.Current, "Current");
            Greeting seven = new Greeting("Thomas", "Holland", StatusType.Potential, "Potential");

            Greeting[] customerArr = { one, two, three, four, five, six, seven };
            foreach(Greeting x in customerArr)
            {
                AddContactToDatabase(x);
            }
        }
    }
}