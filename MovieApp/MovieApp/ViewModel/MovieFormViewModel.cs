using MovieApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.ViewModel
{
  public class MovieFormViewModel
  {
    public int id { get; set; }
    [Required,StringLength(250)]
    public string title { get; set; }
    public int year { get; set; }
    [Range(1,10)]
    public double Rate { get; set; }
    [Required, StringLength(2500)]
    public string storyLine { get; set; }
    [Display(Name ="Select poster ...")]
    public byte[] poster { get; set; }
    [Display(Name ="Genere")]
    public byte GenerId { get; set; }
    public IEnumerable<Genere> Generes { get; set; }

  }
}
