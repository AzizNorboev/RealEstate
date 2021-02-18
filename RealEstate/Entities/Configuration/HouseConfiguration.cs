using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Configuration
{
    public class HouseConfiguration : IEntityTypeConfiguration<House>
    {
        public void Configure(EntityTypeBuilder<House> builder)
        {
            builder.HasData
               (
                 new House
                 {
                     Id = 1,
                     Price = 1200,
                     Square = 160,
                     NumOfRooms = 5,
                     ImageURL = "https://img02.cdnbor.uz/storage/uploads/listing_image/2021/02/13/5143259/200x160_fitted/d105b6e989b550fc0ca7d982c25a690f.jpg",
                     Description = "a cool place",
                     Status = HouseStatus.ForRent,
                     RegionId = 1
                     
                 },

                 new House
                 {
                     Id = 2,
                     Price = 110000,
                     Square = 150,
                     NumOfRooms = 4,
                     ImageURL = "https://img04.cdnbor.uz/storage/uploads/listing_image/2021/02/18/5156017/200x160_fitted/998df78b70a2fc148ac91ef55e5a6c3c.jpg",
                     Description = "house for sale asap",
                     Status = HouseStatus.ForSale,
                     RegionId = 1
                     
                 },

                 new House
                 {
                     Id = 3,
                     Price = 1500,
                     Square = 185,
                     NumOfRooms = 5,
                     ImageURL = "https://img05.cdnbor.uz/storage/uploads/listing_image/2020/11/04/4920470/200x160_fitted/80d9206c5310864f26ff35978735ca56.jpg",
                     Description = "good house",
                     Status = HouseStatus.ForRent,
                     RegionId = 1
                     
                 },

                 new House
                 {
                     Id = 4,
                     Price = 111200,
                     Square = 190,
                     NumOfRooms = 5,
                     ImageURL = "https://img10.cdnbor.uz/storage/uploads/listing_image/2020/11/04/4920442/200x160_fitted/c09510779675298b4afba809e48e63ca.jpg",
                     Description = "in a good condition ",
                     Status = HouseStatus.ForSale,
                     RegionId = 1
                     
                 },
                   new House
                   {
                       Id = 5,
                       Price = 1200,
                       Square = 200,
                       NumOfRooms = 5,
                       ImageURL = "https://img09.cdnbor.uz/storage/uploads/listing_image/2020/07/10/4672481/200x160_fitted/14cc822dbc2c8830c5d0a7b3b0675ea1.jpg",
                       Description = "something should've been written here so I wrote",
                       Status = HouseStatus.ForRent,
                       RegionId = 1
                       
                   },

                    new House
                    {
                        Id = 6,
                        Price = 120000,
                        Square = 165,
                        NumOfRooms = 4,
                        ImageURL = "https://img05.cdnbor.uz/storage/uploads/listing_image/2021/01/07/5055201/200x160_fitted/1675204b7ee8bab5877e853e657f0e5c.jpg",
                        Description = "some description",
                        Status = HouseStatus.ForSale,
                        RegionId = 1
                        
                    }
                 );
        }
    }
}
