namespace HTML_Helper_Demo.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Bio { get; set; }

        public string Password { get; set; }

        public bool IsActive { get; set; }

        public string Gender { get; set; }

        public string City { get; set; }

        public List<string> Skills { get; set; }  // For multiple skill selection
    }
}
