using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace Menu.Application.Products.Queries.GetProductsList
{
    public class MenuLookupDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Menu, MenuLookupDto>()
                .ForMember(prVm => prVm.Id,
                    opt => opt.MapFrom(note => note.Id))
                .ForMember(prVm => prVm.Name,
                    opt => opt.MapFrom(note => note.Name));
        }
    }
}
