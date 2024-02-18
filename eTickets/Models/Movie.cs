using eTickets.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Price { get; set; }
        public string CinemaName { get; set; }
        public string MovieActors { get; set; }
        public string MovieProducers { get; set; }
        public MovieCategory MovieCategory { get; set; }
        public string ImageURL { get; set; }

        //RelationShips
        public List<Actor_Movie> Actors_Movies { get; set; }
        //Cinema
        public int CinemaId { get; set; } //Foriegn Key for the Cinema

        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }

        // Producers
        public int ProducerId { get; set; } //Foriegn Key for the Producer

        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }
    }
}
