using Microsoft.AspNetCore.Mvc;
using LibraryManagement.Service.Context;
using LibraryManagement.Service.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnotherController : Controller
    {
        [HttpGet("some1")]
        public async Task<ActionResult<int>> Some1()
        {

            int numberToIncrease = 0;

            using (var context = new LibraryManagementContext())
            {

                var entityToUpdate = context.AnotherTable.FirstOrDefault(e => e.Id == 1);

                entityToUpdate.Number = entityToUpdate.Number + 1;

                numberToIncrease = entityToUpdate.Number;

                context.SaveChanges();


            }

            return Ok(numberToIncrease);
        }

        [HttpGet("some2")]
        public async Task<ActionResult<int>> Some2()
        {

            int numberToIncrease = 0;

            using (var context = new LibraryManagementContext())
            {

                var entityToUpdate = context.AnotherTable.FirstOrDefault(e => e.Id == 1);

                entityToUpdate.Number = entityToUpdate.Number + 5;

                numberToIncrease = entityToUpdate.Number;

                context.SaveChanges();


            }

            return Ok(numberToIncrease);
        }

        [HttpGet("some3")]
        public async Task<ActionResult<int>> Some3()
        {

            int numberToIncrease = 0;

            using (var context = new LibraryManagementContext())
            {

                var entityToUpdate = context.AnotherTable.FirstOrDefault(e => e.Id == 1);

                entityToUpdate.Number = entityToUpdate.Number + 10;

                numberToIncrease = entityToUpdate.Number;

                context.SaveChanges();


            }

            return Ok(numberToIncrease);
        }
    }
}
