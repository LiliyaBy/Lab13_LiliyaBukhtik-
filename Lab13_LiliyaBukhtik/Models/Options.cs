using System.ComponentModel.DataAnnotations;

namespace Lab13_LiliyaBukhtik.Models
{
    public enum Gender
    {
        man,
        woman
    }
    public class Options
    {
        [Required]

        public string name { get; set; }
        [Required]
        public int age { get; set; }
        
        public Gender gender { get; set; }
        

    }

    

}
