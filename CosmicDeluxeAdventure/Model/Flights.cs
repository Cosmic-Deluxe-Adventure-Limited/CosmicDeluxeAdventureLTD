using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CosmicDeluxeAdventure.Model
{
  public class Flights
  {
    [Required]
    int ID { get; set; }
    int FlightID { get; set; }
    DateTime DepartDate { get; set; }
    DateTime ArrivalDate { get; set; }
    int FlightNumber { get; set; }
    int ShipId { get; set; }
    string Destination { get; set; }
    string Departure { get; set; }
    decimal Distance { get; set;}

    //Navigation Properties
    List<Ships> Ships { get; set; }
    List<Seats> Trips { get; set; }

  }
}
