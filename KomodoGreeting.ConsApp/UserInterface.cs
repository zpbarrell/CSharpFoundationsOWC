using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KomodoGreeting.Repository;

namespace KomodoGreeting.ConsApp
{
    public class UserInterface
    {   
        GreetRepository _repo = new GreetRepository();
        bool isRunning = true;
        public void Run()
        {
            _repo.SeedCustomerData();
            while(isRunning)
            {
                _repo.PrintMainMenu();
                string userInput = _repo.GetUserInput();
                MainMenuSwitch(userInput);
            }
        }
        private void MainMenuSwitch(string userInput)
        {
            switch(userInput)
            {
                case "1": 
                CreateNewContact();
                    break;
                case "2": 
                    ViewAllContacts();
                    break;
                case "3":
                    ViewContactsByCustomerStatus();
                    break;
                case "4":
                    //UpdateAContact();
                    break;
                case "5":
                    //DeleteAContact();
                    break;
                case "6":
                    //Exit();
                    break;
                default:
                    break;
            }
        }
        //Create
        private void CreateNewContact()
        {
            Console.WriteLine("First name: ");
            string firstName = _repo.GetUserInput();

            Console.WriteLine("Last Name: ");
            string lastName = _repo.GetUserInput();

            Console.WriteLine("Select Contacts Status With Komodo Insurance.\n" + "1. Current Customer.\n" + "2. Potential Customer.\n" + "3. Past Customer.\n");
            string newContact = _repo.GetUserInput();

            // StatusType? newStatus = CustomerStatusSelectionSwitchCase(newContact);

            string customerStatus = CustomerStatusSelectionSwitchCase(newContact);
            string email = _repo.GetEmailByCustomerStatus(customerStatus);

            StatusType statusOfCustomer = Enum.Parse<StatusType>(customerStatus);

            Greeting newGreet = new Greeting(firstName, lastName, statusOfCustomer, email);
            _repo.AddContactToDatabase(newGreet);

        }
        private void ViewAllContacts()
        {
            List<Greeting> allContacts = _repo.GetAllContacts();
            PrintContacts(allContacts);
        }
        private void ViewContactsByCustomerStatus()
        {
            Console.WriteLine("Which Customer Status Would You Like To See?\n" + "1. Current\n" + "2. Potential\n" + "3. Past\n");
            string statusSelection = _repo.GetUserInput();

            List<Greeting> statusType = _repo.GetContactByType(statusSelection);
        }
        //Helpe Methods
        private void PrintContacts(List<Greeting> contacts)
        {
            foreach(Greeting x in contacts)
            {
                PrintContact(x);
            }
        }
        private void PrintContact(Greeting contact)
        {
            Console.WriteLine($"First Name: {contact.FirstName}\n" + $"Last Name: {contact.LastName}\n" + $"Customer Status: {contact.StatusType}\n");//Add space for sample email to sent to customer based on contact.Type
        }
        private string CustomerStatusSelectionSwitchCase(string newContact)
        {
            switch(newContact)
            {
                case "1":
                    return StatusType.Current.ToString();
                case "2":
                    return StatusType.Potential.ToString();
                case "3": 
                    return StatusType.Past.ToString();
                default:
                    return null;
            }
        }
    }
}