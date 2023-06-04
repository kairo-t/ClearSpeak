namespace ClearSpeakApi.Models
{
    public class Chat
    {
        public string Id { get; set; }
        public List<string> UserIds { get; set; }  // List of user IDs in this chat.
                                                   // Add more properties as needed.
    }

}
