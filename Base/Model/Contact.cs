namespace Base.Model
{
    public class Contact
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Number { get; set; }
        public string Email { get; set; }

        public Contact(string name, string surname, string number, string email)
        {
            Name = name;
            Surname = surname;
            Number = number;
            Email = email;
        }

        public override string ToString()
        {
            return $"{Name} {Surname} - Tel: {Number}, Email: {Email}";
        }
    }
}
