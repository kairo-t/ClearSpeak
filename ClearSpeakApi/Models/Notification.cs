namespace ClearSpeakApi.Models
{
    public class Notification
    {
        public string Id { get; set; }
        public string UserId { get; set; }  // The ID of the user to whom this notification is sent.
        public string Text { get; set; }
        // Add more properties as needed.
    }

}
