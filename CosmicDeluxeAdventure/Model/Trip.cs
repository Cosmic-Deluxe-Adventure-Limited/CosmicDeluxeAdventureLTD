using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CosmicDeluxeAdventure.Model
{
  public class Trip
  {
    [Required]
    public int ID { get; set; }
    public int UserID { get; set; }
    public int FlightID { get; set; }
    public DateTime Added { get; set; }
    
    //status enum

    //Navigation Properties
    public List<UserInfo> UserInfo { get; set; }
    public List<Flight> Flights { get; set; }

  }
}
