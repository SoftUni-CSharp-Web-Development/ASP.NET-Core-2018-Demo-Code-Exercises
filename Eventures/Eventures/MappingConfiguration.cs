using AutoMapper;
using Eventures.Areas.Event.ViewModels;
using Eventures.Models;
using Eventures.ViewModels;

namespace Eventures
{
    public class MappingConfiguration : Profile
    {
        public MappingConfiguration()
        {
            this.CreateMap<RegisterViewModel, EventuresUser>();
            this.CreateMap<EventureEvent, EventureEventViewModel>();
            this.CreateMap<Order, EventureEventViewModel>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Event.Name));
            this.CreateMap<EventureEventViewModel, Order>()
                .ForMember(dest => dest.Event.Name, opt => opt.MapFrom(src => src.Name));

            // IMapTo<Destination>, IMapFrom<Source>
            // getAllClasses that implement IMapTo
            // typeOf(classThatImplementsIMapTo), typeOf(classThatIsGenericParamOfIMapToInterface)
            // typeOf(classThatIsGenericParamOfIMapFromInterface), typeOf(classThatImplementsIMapFrom)
        }
    }
}
