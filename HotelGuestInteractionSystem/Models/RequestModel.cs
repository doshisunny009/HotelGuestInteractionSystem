namespace HotelGuestInteractionSystem.Models
{
    public class RequestModel
    {
        public int RequestId { get; set; }
        public int RoomNo { get; set; }
        public string GuestName { get; set; }
        public string RequestCategory { get; set; }
        public string RequestDescription { get; set; }
        public bool IsRequestCompleted { get; set; }
        public DateTime RequestTimestamp { get; set; }
        public string Feedback { get; set; }
    }
}
