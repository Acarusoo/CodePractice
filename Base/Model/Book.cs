
using Base.Model;

namespace TelephoneBook.Model
{
    public class Book
    {
        private List<Contact> contacts = new();

        public void AddContact(Contact c) => contacts.Add(c);
        
        public bool DeleteContact(string name, string surname)
        {
            var con = contacts.FirstOrDefault(x => x.Name == name && x.Surname == surname);
            if (con != null)
            {
                contacts.Remove(con);
                return true;
            }
            return false;
        }

        public List<Contact> Search(string request)
        {
            return contacts.Where(c => c.Name.Contains(request) || c.Surname.Contains(request)).ToList();
        }

        public List<Contact> All()
        {
            return contacts.OrderBy(c => c.Name).ThenBy(c => c.Surname).ToList();
        }
    }
}
