using MovieLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;



namespace MovieLibrary.Controllers
{
    public class MovieController : ApiController
    {
        private ApplicationDbContext db;

        // GET api/values
        public MovieController()
        {
            db = new ApplicationDbContext();
        }
        public IEnumerable<Movie> Get()
        {
            // Retrieve all movies from db logic

            return db.Movies.ToList();
        }

        // GET api/values/5
        public string Get(int id)
        {
            // Retrieve movie by id from db logic
            Movie moviesToUpdate = db.Movies.Where(s => s.Id == id).Single();
            return "Movie";
        }
        // POST api/values
        public void Post([FromBody]Movie value)
        {
            // Create movie in db logic
            db.Movies.Add(value);
            db.SaveChanges();
         
        }

        // PUT api/values/5
        public string Put(int id, [FromBody]Movie movie)
        {
            // Update movie in db logic
            var MoviesInDB = db.Movies.Single(m => m.Id == id);
            MoviesInDB.MovieId = MoviesInDB.MovieId;
            MoviesInDB.Title = MoviesInDB.Title;
            MoviesInDB.Genre = MoviesInDB.Genre;
            db.SaveChanges();
            return "Movie";
        }

        //DELETE api/values/5
        //public void Delete(int id)
        //{
        //    // Delete movie from db logic
        //    Movie movie = db.Movies.Find(id);
        //    if (movie == null)
        //    {
                
        //    }
           
        
    }
}