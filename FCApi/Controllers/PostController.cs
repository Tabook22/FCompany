using System.Collections.Generic;
using System.Threading.Tasks;
using FCApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FCApi.Controllers
{
    public class PostController : Controller
    {
        private readonly FCDbContext context;
        public PostController(FCDbContext context)
        {
            this.context = context;
        }
[HttpGet("/api/GetPost")]
        public async Task<IEnumerable<Post>> getPost(){
            return await context.Posts.ToListAsync();
        }
    }
}