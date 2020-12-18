using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCore_RecordType_Api.DataAccess;
using EFCore_RecordType_Api.Models;
using EFCore_RecordType_Api.Models.Records;
using EFCore_RecordType_Api.Service.Mapper;

namespace EFCore_RecordType_Api.Service
{
    public class PersonService
    {
        private readonly RecordMapper<PersonBase, Person> _recordMapper;
        private readonly EntityMapper<Person, PersonBase> _entityMapper;
        private readonly MyDbContext _dbContext;

        public PersonService(
            RecordMapper<PersonBase, Person> recordMapper,
            EntityMapper<Person, PersonBase> entityMapper,
            MyDbContext dbContext)
        {
            _recordMapper = recordMapper;
            _entityMapper = entityMapper;
            _dbContext = dbContext;
        }

        public IEnumerable<PersonBase> Get() => _dbContext.Persons.Select(x => _entityMapper.Map(x));

        public async Task<Person> Add(PersonBase newPerson)
        {
            var entity = _recordMapper.Map(newPerson);
            await _dbContext.Persons.AddAsync(entity);
            await _dbContext.SaveChangesAsync();

            return entity;
        }
    }
}
