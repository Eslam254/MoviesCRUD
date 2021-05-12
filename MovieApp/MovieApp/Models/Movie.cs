using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieApp.Models
{
  public class Movie
  {
    public int Id { get; set; }
    [Required , MaxLength(250)]
    public string title { get; set; }
    public int year { get; set; }
    public double Rate { get; set; }
    [Required , MaxLength(2500)]
    public string storyLine { get; set; }

    [Required]
    public byte[] poster { get; set; }
    public byte GenerId { get; set; }

    public Genere Genere   { get; set; }
  }
}
