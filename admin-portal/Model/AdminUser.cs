using System.Text.Json.Serialization;

namespace admin_portal.Model
{
    public class AdminUser
    {
        [Key]
        public Guid AdminID { get; set; }   
        public string AdminName { get; set; }
        public string EmailID { get; set; }
        public string Password { get; set; }
        public string  PhoneNo { get; set; }

    }
}
