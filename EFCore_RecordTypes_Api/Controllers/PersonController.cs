using System.Collections.Generic;
using System.Threading.Tasks;
using EFCore_RecordType_Api.Models;
using EFCore_RecordType_Api.Models.Records;
using EFCore_RecordType_Api.Service;
using Microsoft.AspNetCore.Mvc;

namespace EFCore_RecordType_Api.Controllers
{
    [ApiController]
    [Route("persons")]
    public class PersonController : ControllerBase
    {
        private readonly PersonService _personService;

        public PersonController(PersonService personService)
        {
            _personService = personService;
        }

        [HttpGet]
        public IEnumerable<PersonBase> Get() => _personService.Get();

        [HttpPost]
        public async Task<Person> Save([FromBody] PersonBase newPerson) => await _personService.Add(newPerson);
    }
}
