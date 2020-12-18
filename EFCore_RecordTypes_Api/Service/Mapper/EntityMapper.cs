using AutoMapper;
using EFCore_RecordType_Api.Models;
using EFCore_RecordType_Api.Models.Records;

namespace EFCore_RecordType_Api.Service.Mapper
{
    public class EntityMapper<TEntity, TRecordModel> where TEntity : EfEntityBase where TRecordModel : RecordBase
    {
        private readonly AutoMapper.Mapper _mapper;

        public EntityMapper()
        {
            var mapperConfig = new MapperConfiguration(config => config.CreateMap<TEntity, TRecordModel>());
            _mapper = new AutoMapper.Mapper(mapperConfig);
        }

        public TRecordModel Map(TEntity source)
        {
            return _mapper.Map<TRecordModel>(source);
        }
    }
}
