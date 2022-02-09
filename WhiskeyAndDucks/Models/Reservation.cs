namespace WhiskeyAndDucks.Models
{
    public class Reservation
    {
        public bool ClubMember { get; set; }
        public DateTime Date { get; set; }
        public int GroupSize { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public OccasionType Type { get; set; }
    }

        public enum OccasionType
        {
            None,
            Birthday,
            Anniversary,
            BachelorParty,
            BacheloretteParty,
            Graduation
        }
}
