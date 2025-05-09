using System.Reflection.Metadata;
using Microsoft.AspNetCore.Mvc;
using VID.Models;
using VID.Repositories;

namespace VID.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ApplicationController : ControllerBase
    {
        private readonly IGenericRepository<Application> _repository;

        public ApplicationController(IGenericRepository<Application> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Application>>> GetAll()
        {
            var children = await _repository.GetAllAsync();
            return Ok(children);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Application>> GetById(int id)
        {
            var child = await _repository.GetByIdAsync(id);
            if (child == null)
            {
                return NotFound();
            }
            return Ok(child);
        }

        [HttpPost]
        public async Task<ActionResult<Application>> Create(Application application)
        {
            try
            {
                // Check if application with this PersonId already exists
                var allApplications = await _repository.GetAllAsync();
                bool exists = allApplications.Any(a => a.PersonId == application.PersonId);

                if (exists)
                {
                    return BadRequest("An application with this ID number already exists.");
                }

                var result = await _repository.CreateAsync(application);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }


        [HttpGet("CheckExists/{personId}")]
        public async Task<IActionResult> CheckExists(string personId)
        {
            try
            {
                // Get all applications and filter by PersonId
                var allApplications = await _repository.GetAllAsync();
                
                // Check if any application has the matching PersonId (as string, no conversion)
                bool exists = allApplications.Any(a => a.PersonId == personId);
                
                Console.WriteLine($"CheckExists for ID {personId}: {exists}");
                
                return Ok(exists);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in CheckExists: {ex.Message}");
                return StatusCode(500, ex.Message);
            }
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Application application)
        {
            if (id != application.ApplicationId)
            {
                return BadRequest();
            }

            //admin.ChildDob = DateTime.SpecifyKind(profile.ChildDob, DateTimeKind.Utc);
            await _repository.UpdateAsync(application);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _repository.DeleteAsync(id);
            return NoContent();
        }
    }
}
