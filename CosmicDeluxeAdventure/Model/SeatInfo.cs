using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CosmicDeluxeAdventure.Model
{
  public class SeatInfo
  {
    [Required]
    public int ID { get; set; }
    public string SeatNumber { get; set; }
    //status ENUM
    
    //Navigation Properties
    public List<Flight> Flights { get; set; }

  }
}