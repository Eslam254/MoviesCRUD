using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieApp.Models
{
  public class Genere
  {
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public byte id { get; set; }

    [Required,MaxLength(100)]
    public string name { get; set; }
  }
}
