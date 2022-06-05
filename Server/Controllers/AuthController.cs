using BlazorAuthentication.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorAuthentication.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpPost]
        public async Task<ActionResult<string>> Login(UserLoginDto request)
        {
            string token = "eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTUxMiIsInR5cCI6IkpXVCIsImN0eSI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoiYm9iIiwiZXhwIjoxNjU0MjE5NDAxfQ.cjUsgJMLa_30jcKSYkaPFN-y9AZ9HJdFzOQePL5Ut2i2FwRyycZsetQ6fN9hce998LyY1UVJqQBm54-_lNLFZA";
            return token;
        }
    }
}
