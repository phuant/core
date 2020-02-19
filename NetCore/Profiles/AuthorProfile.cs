using AutoMapper;
using NetCore.Model;
using NetCore.ViewModel;

namespace NetCore.Profiles
{
    public class AuthorProfile : Profile
    {
        public AuthorProfile()
        {
            CreateMap<Author, AuthorViewModel>();
            CreateMap<AuthorViewModel, Author>();
        }
    }
}
