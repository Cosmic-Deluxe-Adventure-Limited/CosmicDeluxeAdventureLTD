using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CosmicDeluxeAdventure.Model
{
  public class Seat
  {
    [Required]
    public int ShipID {get; set;}
    public string SeatNumber { get; set; }

    //Class Enum
    List<Ship> Ships { get; set; }
  }
}
