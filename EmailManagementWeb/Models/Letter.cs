using System;
using System.Data.Entity;

namespace EmailManagementWeb.Models
{
    public class Letter
    {
        public int LetterID { get; set; }
        public string Title { get; set; }
        public DateTime DateTime { get; set; }
        public int SenderID { get; set; }
        public int ReceiverID { get; set; }
        public string Text { get; set; }
    }
    
    public class LettersDbContext : DbContext
    {
        public DbSet<Letter> Letters { get; set; }
    }
}