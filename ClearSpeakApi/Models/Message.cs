namespace ClearSpeakApi.Models
{
    public class Message
    {
        public string Id { get; set; }
        public string ChatId { get; set; }
        public string UserId { get; set; }  // The ID of the user who sent this message.
        public string Text { get; set; }
        public DateTime Timestamp { get; set; }
        // Add more properties as needed.
    }
}
