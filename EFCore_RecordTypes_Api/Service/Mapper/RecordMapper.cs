using AutoMapper;
using EFCore_RecordType_Api.Models;
using EFCore_RecordType_Api.Models.Records;

namespace EFCore_RecordType_Api.Service.Mapper
{
    public class RecordMapper<TRecordModel, TEntity> where TEntity : EfEntityBase where TRecordModel : RecordBase
    {
        private readonly AutoMapper.Mapper _mapper;

        public RecordMapper()
        {
            var mapperConfig = new MapperConfiguration(config => config.CreateMap<TRecordModel, TEntity>());
            _mapper = new AutoMapper.Mapper(mapperConfig);
        }

        public TEntity Map(TRecordModel source)
        {
            return _mapper.Map<TEntity>(source);
        }
    }
}