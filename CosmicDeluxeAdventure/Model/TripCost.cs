using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CosmicDeluxeAdventure.Model
{
  public class TripCost
  {
    [Required]
    int ID { get; set; }
    [Required]
    int TripID { get; set; }
    decimal Price { get; set; }
    decimal Cost { get; set; }
  }
}
