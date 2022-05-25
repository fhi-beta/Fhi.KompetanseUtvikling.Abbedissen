using AutoMapper;
using Fhi.Abbedissen.KompetanseAPI.DTO;
using Fhi.Abbedissen.KompetanseAPI.Model;

namespace Fhi.Abbedissen.KompetanseAPI.Profile;

public class KompetanseProfile : AutoMapper.Profile
{
    public KompetanseProfile()
    {
        CreateMap<Kompetanse, KompetanseDTO>().ReverseMap();
         
        

    }
}
