using _13_RestaurantRater.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace _13_RestaurantRater.Controllers
{
    public class RatingController : ApiController
    {
        private readonly RestaurantDbContext _context = new RestaurantDbContext();


        //C
        [HttpPost]
        public async Task<IHttpActionResult> PostRestaurant(Rating model)
        {
            if (ModelState.IsValid)
            {
                _context.Ratings.Add(model);
                await _context.SaveChangesAsync();

                return Ok(); // 200
            }

            return BadRequest(ModelState); //400
        }

        //R

        [HttpGet]
        public async Task<IHttpActionResult> GetAllRatings()
        {
            List<RatingListItem> ratings = await _context.Ratings.Select(r => new RatingListItem(){
                Id = r.Id,
                FoodScore = r.FoodScore,
                //AverageScore = r.AverageScore,
                RestaurantName = r.Restaurant.Name,
            })
                .ToListAsync();
            return Ok(ratings);
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetAllRatingsForRestaurant(int id)
        {
            List<RatingListItem> ratings = await _context.Ratings
                //LINQ (Language Integrated Query)
                .Where(r => r.RestaurantId == id)
                .Select(r=> new RatingListItem()
                {
                    Id = r.Id,
                    FoodScore = r.FoodScore,
                    //AverageScore = r.AverageScore,
                    RestaurantName = r.Restaurant.Name,
                })
                 .ToListAsync();
            return Ok(ratings);
        }
    }
}
