using Microsoft.AspNetCore.Mvc;
using STUDY.Blazor.FifaWorldCup.Server.Models;
using STUDY.Blazor.FifaWorldCup.Shared.Models;

namespace STUDY.Blazor.FifaWorldCup.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MatchesController : ControllerBase
    {
        readonly DatabaseContext _dbContext = new();

        public MatchesController(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public List<Match> GetAllMatches()
        {
            try
            {
                return _dbContext.Matches.ToList();
            }
            catch
            {
                throw;
            }
        }

        [HttpPost]
        public void UpdateMatch(Match match)   
        {
            try
            {
                _dbContext.Matches.Update(match);
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}