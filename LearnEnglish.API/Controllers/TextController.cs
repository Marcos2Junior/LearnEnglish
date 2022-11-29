using LearnEnglish.API.Context;
using LearnEnglish.API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace LearnEnglish.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TextController : ControllerBase
    {
        private readonly LearnEnglishDbContext _context;

        public TextController(LearnEnglishDbContext context)
        {
            _context = context;
        }

        [HttpGet("filter")]
        public async Task<IActionResult> Get(string? text,bool translated = false)
        {
            List<Text> result = new();
            text = ClearInputText(text);
            if (!string.IsNullOrEmpty(text))
            {
                result = await FilterAsync(x => translated ? x.TranslateNormalized.Contains(text) : x.ValueNormalized.Contains(text));
            }

            return Ok(result);
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create(string value, string translate, int groupId)
        {
            Text text = new()
            {
                DateTime = DateTime.UtcNow,
                TextGroupID = groupId,
                Translate = translate,
                TranslateNormalized = ClearInputText(translate),
                Value = value,
                ValueNormalized = ClearInputText(value),
            };

            if(string.IsNullOrEmpty(text.TranslateNormalized) || string.IsNullOrEmpty(text.ValueNormalized))
            {
                return BadRequest();
            }

            await _context.AddAsync(text);
            await _context.SaveChangesAsync();
            return StatusCode((int)HttpStatusCode.Created);
        }

        private static string ClearInputText(string? text) => text?.ToLower().OnlyLettersAndNumbers().ReplaceAccents() ?? string.Empty;

        private async Task<List<Text>> FilterAsync(System.Linq.Expressions.Expression<Func<Text, bool>> predicate) =>
            await _context.Texts.Where(predicate).ToListAsync();
    }
}
