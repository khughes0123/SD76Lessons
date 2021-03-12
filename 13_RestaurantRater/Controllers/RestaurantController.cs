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
    // API controller just deals with data
    // MVC controller (red badge) also returns views (HTML/CSS/JS)
    public class RestaurantController : ApiController
    {
        private readonly RestaurantDbContext _context = new RestaurantDbContext();

        //C
        [HttpPost]
        public async Task<IHttpActionResult> PostRestaurant(Restaurant model)
        {
            if (ModelState.IsValid)
            {
                _context.Restaurants.Add(model);
                await _context.SaveChangesAsync();

                return Ok(); // 200
            }

            return BadRequest(ModelState); //400
        }

        // R
        [HttpGet]
        public async Task<IHttpActionResult> GetAllRestaurants()
        {
            List<Restaurant> restaurants = await _context.Restaurants.ToListAsync();
            List<RestaurantListItem> restaurantList = restaurants.Select(r => new RestaurantListItem()
            // Select convert a list of one type of thing into a list of another type of thing
            {
                Name = r.Name,
                Address = r.Address,
                Rating = r.Rating,
                Id = r.Id,
            }).ToList();

            //example of select
            /*List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };
            List<string> strings = numbers.Select(n => "#" + n.ToString()).ToList();*/

            return Ok(restaurantList);

            //race condition - a situation where two async tasks happening, not sure which will finish first, how the code run depends on which finishes first (we shouldn't ever have to deal with that)
        }

        [HttpGet]

        public async Task<IHttpActionResult> GetRestaurantById(int id)
        {
            Restaurant restaurant = await _context.Restaurants.FindAsync(id);


            if (restaurant == default) //null)
            {
                return NotFound(); //404
            }

            RestaurantDetail restaurantDetail = new RestaurantDetail()
            {
                Name = restaurant.Name,
                Id = restaurant.Id,
                Address = restaurant.Address,
                Rating = restaurant.Rating,
                AverageFoodScore = restaurant.AverageFoodScore,
            };

            return Ok(restaurantDetail);
        }

        // U
        [HttpPut]
        public async Task<IHttpActionResult> UpdateRestaurant([FromUri] int id, [FromBody] Restaurant model)
        {
            if (ModelState.IsValid)
            {
                Restaurant restaurant = await _context.Restaurants.FindAsync(id);

                if (restaurant == null)
                {
                    return NotFound();
                }

                restaurant.Name = model.Name;
                restaurant.Address = model.Address;
                //restaurant.Rating = model.Rating;

                await _context.SaveChangesAsync();

                return Ok();
            }

            return BadRequest(ModelState);
        }

        // D

        [HttpDelete]

        public async Task<IHttpActionResult> DeleteRestaurantById(int id)
        {
            Restaurant restaurant = await _context.Restaurants.FindAsync(id);

            if (restaurant == default)
            {
                return NotFound(); //404
            }

            _context.Restaurants.Remove(restaurant);

            if (await _context.SaveChangesAsync() == 1)
            {
                return Ok(); //200
            }

            return InternalServerError(); //500

        }

    }
}
