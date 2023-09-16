using AutoMapper;
using DevPortfolioShared.Models;

namespace DevPortfolioServer.Data
{
    internal sealed class DTOMappings : Profile
    {
        public DTOMappings()
        {
            CreateMap<Post, PostDTO>().ReverseMap();
        }
    }
}
