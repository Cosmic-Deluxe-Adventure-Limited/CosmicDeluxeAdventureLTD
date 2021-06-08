using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CosmicDeluxeAdventure.Model
{
  public class Ship
  {
    [Required]
    public int ID {get; set;}
    int ShipNumber { get; set; }
    // Navigation Properties

    List<Flight> Flghts { get; set; }
    List<SeatInfo> Seats { get; set; }

  }
}
