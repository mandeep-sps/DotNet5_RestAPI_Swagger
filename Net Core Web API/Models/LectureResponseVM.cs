namespace Net_Core_Web_API.Models
{
    public class LectureResponseVM
    {
        public Guid Id { get; set; }

        public string? LectureDesc { get; set; }

        public string? BoardUrl { get; set; }

        public decimal? Credit { get; set; }

        public Guid TeacherId { get; set; }
    }
}
