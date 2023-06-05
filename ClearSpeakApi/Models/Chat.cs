namespace ClearSpeakApi.Models
{
    public class Chat
    {
        public string Id { get; set; }
        public List<UserChat> UserChats { get; set; }
    }
}
