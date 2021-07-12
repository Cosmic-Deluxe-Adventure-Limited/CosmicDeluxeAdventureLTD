using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CosmicDeluxeAdventure.Model
{
  public class Location
  {
    [Required]
    int ID { get; set; }
    [Required]
    string Name { get; set; }
    [Required]
    string Description { get; set; }
  }
}

