namespace ClearSpeakApi.Models
{
    public class AuthCode
    {
        public string Code { get; set; }
        public string PhoneNumber { get; set; }  // The phone number to which the code was sent.
    }

}
