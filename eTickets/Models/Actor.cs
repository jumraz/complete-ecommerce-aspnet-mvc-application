using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }
        public string ProfilePictureURL { get; set; }
        public string Bio { get; set; }
        public string FullName { get; set; }

        //RelationShips
        public List<Actor_Movie> Actors_Movies { get; set; }

    }
}
