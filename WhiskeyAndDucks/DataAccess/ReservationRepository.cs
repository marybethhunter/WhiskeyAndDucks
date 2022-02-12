using WhiskeyAndDucks.Models;

namespace WhiskeyAndDucks.DataAccess
{
    public class ReservationRepository
    {
        //this list is in lieu of a database for right now
        private static List<Reservation> _reservations = new List<Reservation>()
        {
            new Reservation()
            {
                ClubMember = true,
                Date = DateTime.Now,
                GroupSize = 4,
                Id = 1,
                Name = "Hunter",
                Type = OccasionType.None
            },
            new Reservation()
            {
                ClubMember = false,
                Date = DateTime.Now.AddDays(7),
                GroupSize = 8,
                Id = 2,
                Name = "Hignite",
                Type = OccasionType.Birthday
            },
            new Reservation()
            {
                ClubMember = true,
                Date = DateTime.Now.AddDays(2),
                GroupSize = 2,
                Id = 3,
                Name = "Meadows",
                Type = OccasionType.Anniversary
            },
            new Reservation()
            {
                ClubMember = false,
                Date = DateTime.Now.AddMonths(1),
                GroupSize = 10,
                Id = 4,
                Name = "Beckman",
                Type = OccasionType.None
            },
            new Reservation()
            {
                ClubMember = true,
                Date = DateTime.Now.AddDays(19),
                GroupSize = 2,
                Id = 5,
                Name = "Davis",
                Type = OccasionType.BachelorParty
            },
        };

        internal object GetById(int id)
        {
            var match = _reservations.FirstOrDefault(r => r.Id == id);
            return match;
        }

        internal IEnumerable<Reservation> GetByType(OccasionType occasionType)
        {
            var matchingReservations = _reservations.Where(reservation => reservation.Type == occasionType);
            return matchingReservations;
        }

        internal void Post(Reservation newReservation)
        {
            _reservations.Add(newReservation);
        }

        internal List<Reservation> GetAll()
        {
            return _reservations;
        }
    }
}
