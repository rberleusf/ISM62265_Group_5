namespace Competition2.Models
{
    public class Staff : People
    {
        public string Position { get; set; }
        public string Department { get; set; }
        
        public Staff(string name, string email, string id, string position, string department)
        {
            Name = name;
            Email = email;
            Id = id;
            Position = position;
            Department = department;
        }
    }
    
}