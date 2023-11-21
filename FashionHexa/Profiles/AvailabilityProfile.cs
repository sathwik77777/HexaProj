﻿using AutoMapper;
using FashionHexa.DTO;
using FashionHexa.Entities;
namespace FashionHexa.Profiles
{
    public class AvailabilityProfile
    {
        public AvailabilityProfile() 
        {
            CreateMap<Availability, AvailabilityDTO>();
            CreateMap<AvailabilityDTO, Availability>();

        }
    }
}
