using AutoMapper;
using SMS.Data.Dto;

namespace SMS.Common
{
    public static class MapperConfig
    {
        public static IMapper GetMapperConfigs()
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new NLogProfile());
            });

            return mappingConfig.CreateMapper();
        }
    }
}
