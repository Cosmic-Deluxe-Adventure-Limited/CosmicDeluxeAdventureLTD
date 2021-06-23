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
    public int FlightID { get; set; }
    public DateTime DepartDate { get; set; }
    public DateTime ArrivalDate { get; set; }
    public int FlightNumber { get; set; }
    public int ShipId { get; set; }
    public string Destination { get; set; }
    public string Departure { get; set; }
    public decimal Distance { get; set;}

    //Navigation Properties
    public List<Ship> Ship { get; set; }
    public List<SeatInfo> Trips { get; set; }

  }
}
