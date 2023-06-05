namespace ClearSpeakApi.Models
{
    public class User
    {
        public string Id { get; set; }
        public string PhoneNumber { get; set; }
        public List<UserChat> UserChats { get; set; }
    }
}