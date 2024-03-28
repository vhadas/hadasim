using coronaApi.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace coronaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembersController : ControllerBase
    {
        private readonly DataContext _context = new DataContext();

        // GET: api/<MembersController>
        [HttpGet]
        public IEnumerable<Member> Get()
        {
            return _context.members;
        }

        // GET api/<MembersController>/5
        [HttpGet("{id}")]
        public ActionResult Get(string id)
        {
            var member = _context.members.ToList().Find(m => m.Id == id);
            if (member == null)
            {
                return NotFound();
            }
            return Ok(member);
        }

        // POST api/<MembersController>
        [HttpPost]
        public void Post([FromBody] Member newMember)
        {
            _context.members.Add(newMember);
        }

        // PUT api/<MembersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MembersController>/5
        [HttpDelete("{id}")]
        public ActionResult Put(string id, [FromBody] Member updateMember)
        {
            var member = _context.members.ToList().Find(m => m.Id == id);
            if (member == null)
            {
                return NotFound();
            }
            member.FullName = updateMember.FullName;
            member.FullAddress = updateMember.FullAddress;
            member.BirthDate = updateMember.BirthDate;
            member.Telephone = updateMember.Telephone;
            member.Phone = updateMember.Phone;
            member.Date1 = updateMember.Date1;
            member.Date2 = updateMember.Date2;
            member.Date3 = updateMember.Date3;
            member.Date4 = updateMember.Date4;
            member.Maker1 = updateMember.Maker1;
            member.Maker2 = updateMember.Maker2;
            member.Maker3 = updateMember.Maker3;
            member.Maker4 = updateMember.Maker4;
            member.DateOfResult = updateMember.DateOfResult;
            member.DateOfRecovery = updateMember.DateOfRecovery;
            return Ok();
        }
    }
}
