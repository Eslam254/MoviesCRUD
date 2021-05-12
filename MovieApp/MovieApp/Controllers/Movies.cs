using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieApp.Models;
using Microsoft.EntityFrameworkCore;
using MovieApp.ViewModel;
using System.IO;
using NToastNotify;

namespace MovieApp.Controllers
{
  public class Movies : Controller
  {
    private readonly ApplicationDBContext _context;
   private readonly IToastNotification _toastNotification;
    private long _maxAllowedPosterSize = 1048576;
    private new List<string> _allowedExtenstions = new List<string> { ".jpg", ".png" };
    public Movies(ApplicationDBContext context , IToastNotification toastNotification)
    {
      this._context = context;
      this._toastNotification = toastNotification;
    }
    public async Task<IActionResult> Index()
    {
      var movies = await _context.Movies.OrderByDescending(m=>m.Rate).ToListAsync();
      return View(movies);
    }

    public async Task<IActionResult> Create()
    {
      var viewModel = new MovieFormViewModel
      {
        Generes = await _context.Generes.ToListAsync()
      };
      return View("MovieForm",viewModel);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(MovieFormViewModel model)
    {
      if (!ModelState.IsValid)
      {
        model.Generes = await _context.Generes.OrderBy(m => m.name).ToListAsync();
        return View("MovieForm", model);
      }

      var files = Request.Form.Files;

      if (!files.Any())
      {
        model.Generes = await _context.Generes.OrderBy(m => m.name).ToListAsync();
        ModelState.AddModelError("Poster", "Please select movie poster!");
        return View("MovieForm", model);
      }

      var poster = files.FirstOrDefault();
      var allowedExtenstions = new List<string> { ".jpg", ".png" };

      if (!allowedExtenstions.Contains(Path.GetExtension(poster.FileName).ToLower()))
      {
        model.Generes = await _context.Generes.OrderBy(m => m.name).ToListAsync();
        ModelState.AddModelError("Poster", "Only .PNG, .JPG images are allowed!");
        return View("MovieForm", model);
      }
      if (poster.Length > _maxAllowedPosterSize)
      {
        model.Generes = await _context.Generes.OrderBy(m => m.name).ToListAsync();
        ModelState.AddModelError("Poster", "Poster cannot be more than 1 MB!");
        return View("MovieForm", model);
      }

      using var datastream = new MemoryStream();
      await poster.CopyToAsync(datastream);
      var movies = new Movie
      {
        title = model.title,
        GenerId = model.GenerId,
        year = model.year,
        Rate = model.Rate,
        storyLine = model.storyLine,
        poster = datastream.ToArray()
      };
      _context.Movies.Add(movies);
      _context.SaveChanges();
      _toastNotification.AddSuccessToastMessage("Movie created successfully");
      return RedirectToAction("Index");
    }

    public async Task<IActionResult> Edit (int? id)
    {
      if (id == null)
      {
        return BadRequest();
      }

      var movie = await _context.Movies.FindAsync(id);

      if (movie == null)
        return NotFound();

      var viewModel = new MovieFormViewModel
      {
        id = movie.Id,
        title = movie.title,
        GenerId = movie.GenerId,
        year = movie.year,
        Rate = movie.Rate,
        storyLine = movie.storyLine,
        poster = movie.poster,
        Generes = await _context.Generes.ToListAsync()
      };

      return View("MovieForm",viewModel);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(MovieFormViewModel model)
    {
      if (!ModelState.IsValid)
      {
        model.Generes = await _context.Generes.OrderBy(m => m.name).ToListAsync();
        return View("MovieForm", model);
      }

      var movie = await _context.Movies.FindAsync(model.id);

      if (movie == null)
        return NotFound();

      var files = Request.Form.Files;

      if (files.Any())
      {
        var poster = files.FirstOrDefault();

        using var dataStream = new MemoryStream();

        await poster.CopyToAsync(dataStream);

        model.poster = dataStream.ToArray();

        if (!_allowedExtenstions.Contains(Path.GetExtension(poster.FileName).ToLower()))
        {
          model.Generes = await _context.Generes.OrderBy(m => m.name).ToListAsync();
          ModelState.AddModelError("Poster", "Only .PNG, .JPG images are allowed!");
          return View("MovieForm", model);
        }

        if (poster.Length > _maxAllowedPosterSize)
        {
          model.Generes = await _context.Generes.OrderBy(m => m.name).ToListAsync();
          ModelState.AddModelError("Poster", "Poster cannot be more than 1 MB!");
          return View("MovieForm", model);
        }

        movie.poster = model.poster;
      }


      movie.title = model.title;
      movie.GenerId = model.GenerId;
      movie.year = model.year;
      movie.Rate = model.Rate;
      movie.storyLine = model.storyLine;

      _context.SaveChanges();
      _toastNotification.AddSuccessToastMessage("Movie updated successfully");

      return RedirectToAction("Index");
    }


    public async Task<IActionResult> Details(int? id)
    {
      if (id == null)
        return BadRequest();

      var movie = await _context.Movies.Include(m => m.Genere).SingleOrDefaultAsync(m => m.Id == id);

      if (movie == null)
        return NotFound();

      return View(movie);
    }

    public async Task<IActionResult> Delete(int? id)
    {
      if (id == null)
        return BadRequest();

      var movie = await _context.Movies.FindAsync(id);

      if (movie == null)
        return NotFound();

      _context.Movies.Remove(movie);
      _context.SaveChanges();

      return Ok();
    }

  }
}
