using System.ComponentModel.DataAnnotations; // Add this for StringLength

namespace Mission06_Paris.Models // Ensure the namespace matches your project structure
{
   
    public class Movie
    { 
        [Key]
        public int MovieId { get; set; }

        // Initialize with default values or mark as nullable
        [Required]
        public string Title { get; set; } = string.Empty; 
       
        public string? Director { get; set; } = string.Empty;
        [Required]
        public int Year { get; set; }
        public string? Rating { get; set; } = string.Empty;

        // Add additional properties if needed 
        
        //TWO LINES BELOW SHOW FOREGIN KEy' RELATIONSHIP
        public int? CategoryId { get; set; } // Mark as nullable if optional 
        public Category? Category { get; set; }
        
        [Required]
        public bool Edited { get; set; }
        public string? LentTo { get; set; } // Mark as nullable if optional
        public string? Notes { get; set; } // Mark as nullable if optional 
        
        
        //MISSION 7 FIELD  
        [Required]
        public bool CopiedToPlex { get; set; }
    }
}