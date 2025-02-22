using System.ComponentModel.DataAnnotations; // Add this for StringLength

namespace Mission06_Paris.Models // Ensure the namespace matches your project structure
{
   
    public class Movie
    {
        public int MovieId { get; set; }

        // Initialize with default values or mark as nullable
        public string Title { get; set; } = string.Empty;
        public string Director { get; set; } = string.Empty;
        public int Year { get; set; }
        public string Rating { get; set; } = string.Empty;

        // Add additional properties if needed
        public string? Category { get; set; } // Mark as nullable if optional
        public bool Edited { get; set; }
        public string? LentTo { get; set; } // Mark as nullable if optional
        public string? Notes { get; set; } // Mark as nullable if optional
    }
}