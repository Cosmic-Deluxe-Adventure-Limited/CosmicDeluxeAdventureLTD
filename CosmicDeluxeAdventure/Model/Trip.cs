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
    // #2 int value in and out of database
    public int FlightStatus
    {
      get
      {
        return (int)this.TripStatus;
      }
      set
      {
        TripStatus = (TripCondition)value;
      }
    }
    //Navigation Properties
    public List<UserInfo> UserInfo { get; set; }
    public List<Flight> Flights { get; set; }

  //Enum Method and definition

  //#3 this will be what will be called when we need to use the enum
    public TripCondition TripStatus { get; set; }
  //#1 Enum Definition
    public enum TripCondition
  {
    Saved = 1,
    Booked = 2,
    Completed = 3
  }
  }
}

