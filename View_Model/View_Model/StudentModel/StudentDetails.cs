using View_Model.Models;

namespace View_Model.StudentModel
{
    public class StudentDetails
    {
        public Student Std { get; set; }
        public Address Add { get; set; }
        public string Header { get; set; }
        public string Title { get; set; }
    }
}
