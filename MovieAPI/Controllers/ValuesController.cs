using MovieAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MovieAPI.Controllers
{
    public class ValuesController : ApiController
    {
        public List<Movie> movies = new List<Movie>() {
            new Movie(0,"Jimmy's RoadTrip",99,Genre.Adventure),
            new Movie(1, "Space Jam", 120, Genre.Action),
            new Movie(2, "The Big Lebowski", 105, Genre.Comedy),
            new Movie(3, "You've Got Mail", 111, Genre.Romance)
        };
        // GET api/values
        public IEnumerable<Movie> Get()
        {
            return movies;
        }

        // GET api/values/5
        public Movie Get(int id)
        {
            return movies[id];
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
