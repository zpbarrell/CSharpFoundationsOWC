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
                    UpdateAContact();
                    break;
                case "5":
                    DeleteAContact();
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

            string customerStatus = CustomerStatusSelectionSwitchCase(newContact);
            string email = _repo.GetEmailByCustomerStatus(customerStatus);

            StatusType statusOfCustomer = Enum.Parse<StatusType>(customerStatus);

            Greeting newGreet = new Greeting(firstName, lastName, statusOfCustomer, email);
            _repo.AddContactToDatabase(newGreet);

        }
        private void ViewAllContacts()
        {
            List<Greeting> allContacts = _repo.GetAllContacts();
            allContacts = allContacts.OrderBy(o=>o.LastName).ToList();
            PrintContacts(allContacts);
        }
        private void ViewContactsByCustomerStatus()
        {
            Console.WriteLine("Which Customer Status Would You Like To See?\n" + "1. Current\n" + "2. Potential\n" + "3. Past\n");
            string userStatusSelection = _repo.GetUserInput();
            string statusSelection = _repo.ChangeUserInputToString(userStatusSelection);

            List<Greeting> statusType = _repo.GetContactByType(statusSelection);
            PrintContacts(statusType);
        }
        //UPDATE
        private void UpdateAContact()
        {
            ViewAllContacts();
            Console.WriteLine("Select a contact to update by entering last name: ");
            string contactToUpdate = _repo.GetUserInput();
            Greeting contact = _repo.GetContactByLastName(contactToUpdate);
            if(contact != null)
            {
                PrintContact(contact);
                Console.Write("New First Name: ");
                string newFirst = _repo.GetUserInput();
                Console.Write("New Last Name: ");
                string newLast = _repo.GetUserInput();

                Console.Write("Update Customer Status.\n" + "1.Current\n" + "2. Potential\n" + "3. Past\n");
                string newCustomerStatus = _repo.GetUserInput();

                StatusType? newStatusType = contact.StatusType;
                CustomerStatusSelectionSwitchCase(newCustomerStatus);

                string newEmail = contact.Email;
                //  _repo.EmailSelectionSwitchCase(newCustomerStatus);

                Greeting? updatedContact = new Greeting(newFirst, newLast, newStatusType, newEmail);
            }
        }
        //DELETE
        private void DeleteAContact()
        {
            ViewAllContacts();
            Console.WriteLine("Enter a contact by Last Name to delete: ");
            string nameToDelete = _repo.GetUserInput();
            Greeting contactToDelete = _repo.GetContactByLastName(nameToDelete);
            if(contactToDelete != null)
            {
                bool deleteSuccessful = _repo.DeleteContactFromDatabase(contactToDelete);
                if(deleteSuccessful)
                {
                    Console.WriteLine($"{nameToDelete} successfully deleted.");
                }
                else{
                    Console.WriteLine("No contact by that last name found in our database.");
                }
            }
            else
            {
                Console.WriteLine($"{nameToDelete} not found");
            }
        }
        //Helper Methods
        private void PrintContacts(List<Greeting> contacts)
        {
            foreach(Greeting x in contacts)
            {
                PrintContact(x);
            }
        }
        private void WhatEmail(StatusType statusType)
        {
            string whatEmail = _repo.EmailSelectionSwitchCase(statusType);
             
        }
        private void PrintContact(Greeting contact)
        {
            Console.WriteLine($"First Name: {contact.FirstName}\n" + $"Last Name: {contact.LastName}\n" + $"Customer Status: {contact.StatusType}\n" + $"{contact.Email}\n");
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