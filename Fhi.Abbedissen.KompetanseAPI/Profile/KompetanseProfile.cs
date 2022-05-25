using AutoMapper;
using Fhi.Abbedissen.Felles;
using Fhi.Abbedissen.KompetanseAPI.Model;

namespace Fhi.Abbedissen.KompetanseAPI.Profile;

public class KompetanseProfile : AutoMapper.Profile
{
    public KompetanseProfile()
    {
        CreateMap<Kompetanse, KompetanseDTO>().ReverseMap();
         
        

    }
}
