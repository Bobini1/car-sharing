using System.ComponentModel.DataAnnotations;

namespace ASP.NET1.Models
{
    public class Account
    {
        [Key] public int Account_ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
    }
}
