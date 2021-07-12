using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CosmicDeluxeAdventure.Model
{
  public class Flight
  {
    [Required]
    public int ID { get; set; }
    [Required]
    public DateTime Departure { get; set; }
    [Required]
    public DateTime Arrival { get; set; }
    [Required]

    public string Status { get; set; }
    [Required]
    public long Miles { get; set; }
    //FK
    public Ship ShipId { get; set; }
    public Location Location {get; set;}
  }
}
