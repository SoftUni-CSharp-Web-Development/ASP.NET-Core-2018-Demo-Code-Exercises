using AutoMapper;
using Eventures.Models;
using Eventures.ViewModels;

namespace Eventures
{
    public class MappingConfiguration : Profile
    {
        public MappingConfiguration()
        {
            this.CreateMap<RegisterViewModel, EventuresUser>();
            // getAllClasses that implement IMapTo
            // typeOf(classThatImplementsIMapTo), typeOf(classThatIsGenericParamOfIMapToInterface)
            // typeOf(classThatIsGenericParamOfIMapFromInterface), typeOf(classThatImplementsIMapFrom)
        }
    }
}
