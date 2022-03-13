using System.ComponentModel.DataAnnotations;

namespace ExamTraining
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Firstname { get; internal set; }
        public string Insertion { get; internal set; }
        public string Lastname { get; internal set; }
        public string Description { get; set; }
        public string School { get; set; }
       
    }
}