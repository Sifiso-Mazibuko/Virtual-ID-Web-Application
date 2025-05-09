using Microsoft.AspNetCore.Mvc;
using VID.Models;
using VID.Repositories;

namespace VID.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DocumentController : ControllerBase
    {
        private readonly IGenericRepository<Document> _repository;

        public DocumentController(IGenericRepository<Document> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Document>>> GetAll()
        {
            var children = await _repository.GetAllAsync();
            return Ok(children);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Document>> GetById(int id)
        {
            var child = await _repository.GetByIdAsync(id);
            if (child == null)
            {
                return NotFound();
            }
            return Ok(child);
        }

        [HttpPost]
        public async Task<ActionResult<Document>> Create(Document document)
        {
            //admin.ChildDob = DateTime.SpecifyKind(admin.ChildDob, DateTimeKind.Utc);
            var created = await _repository.CreateAsync(document);
            return CreatedAtAction(nameof(GetById), new { id = created.DocumentId}, created);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Document document)
        {
            // if (id != user.UserId)
            // {
            //     return BadRequest();
            // }

            //admin.ChildDob = DateTime.SpecifyKind(profile.ChildDob, DateTimeKind.Utc);
            await _repository.UpdateAsync(document);
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
