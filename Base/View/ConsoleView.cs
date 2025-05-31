using Base.Model;

namespace TelephoneBook.View
{
    public class ConsoleView
    {
        public void Menu()
        {
            Console.WriteLine("\n----Telephone Book----");
            Console.WriteLine("1. Add Contact\n2. Show all contacts\n3. Search\n4. Remove Contact\n5. Exit\n Choice: ");
        }

        public Contact ShowAddContact()
        {
            Console.WriteLine("----BOOK LIST----\nName: ");
            string name = Console.ReadLine();

            Console.WriteLine("Surname: ");
            string surname = Console.ReadLine();

            Console.WriteLine("Number: ");
            string number = Console.ReadLine();

            Console.WriteLine("Email: ");
            string email = Console.ReadLine();

            return new Contact(name, surname, number, email);
        }

        public void ShowContacts(List<Contact> contacts)
        {
            if (contacts.Count == 0)
            {
                Console.WriteLine("BOOK IS EMPTY");
                return;
            }
            
            foreach (var c in contacts)
            {
                Console.WriteLine(c);
            }
        }

        public void ShowMessage(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
