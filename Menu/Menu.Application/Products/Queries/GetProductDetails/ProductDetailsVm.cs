using System;
using AutoMapper;
using Menu.Application.Common.Mappings;

namespace Menu.Application.Products.Queries.GetProductDetails
{
    public class ProductDetailsVm : IMapWith<Domain.Menu>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? EditDate { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Menu, ProductDetailsVm>()
                .ForMember(prVm => prVm.Name,
                    opt => opt.MapFrom(note => note.Name))
                .ForMember(prVm => prVm.Description,
                    opt => opt.MapFrom(note => note.Description))
                .ForMember(prVm => prVm.Price,
                    opt => opt.MapFrom(note => note.Price))
                .ForMember(prVm => prVm.Id,
                    opt => opt.MapFrom(note => note.Id))
                .ForMember(prVm => prVm.CreationDate,
                    opt => opt.MapFrom(note => note.CreationDate))
                .ForMember(prVm => prVm.EditDate,
                    opt => opt.MapFrom(note => note.EditDate));
        }
    }
}
