namespace BigonApp2.Models.Entities
{
    public class Subscriber
    {
        public string EmailAdress { get; set; }
        public bool IsApproved { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ApprovedAt { get; set; }

    }
}
