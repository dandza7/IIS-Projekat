namespace IIS_Projekat.Models
{
    public class MailData
    {
        // Receiver
        public string To { get; set; }
        /*public List<string> Bcc { get; }

        public List<string> Cc { get; }*/

        // Sender
        public string? From { get; }

        public string? DisplayName { get; }

        public string? ReplyTo { get; }

        public string? ReplyToName { get; }

        // Content
        public string Subject { get; set; }

        public string? Body { get; set; }
    }
}
