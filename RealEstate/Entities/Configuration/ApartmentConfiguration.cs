using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Entities.Configuration
{
    /// <summary>
    /// added new classes for entity configuration instead of having all this code in DbContext class
    /// to orginize the code better and follow SRP
    /// </summary>
    public class ApartmentConfiguration : IEntityTypeConfiguration<Apartment>
    {
        public void Configure(EntityTypeBuilder<Apartment> builder)
        {

            builder.HasData
                (
                  new Apartment
                  {
                      Id = 1,
                      Price = 450,
                      NumOfRooms = 3,
                      FloorNo = 3,
                      Square = 85,
                      Description = "New apartment with furniture",
                      Status = ApartmentStatus.ForRent,
                      ImageURL = "https://img01.cdnbor.uz/storage/uploads/listing_image/2020/09/07/4796303/200x160_fitted/358a23bec1b8765e7d996b8709c1d7bc.jpg",
                      RegionId = 1

                  },

                  new Apartment
                  {
                      Id = 2,
                      Price = 500,
                      NumOfRooms = 3,
                      FloorNo = 2,
                      Square = 80,
                      Description = "New apartment with furniture, TV and internet (students pls don't bother)",
                      Status = ApartmentStatus.ForRent,
                      ImageURL = "https://img07.cdnbor.uz/storage/uploads/listing_image/2020/08/20/4750987/200x160_fitted/8d56f14d874026ea7372fcd5ef38d0fa.jpg",
                      RegionId = 1

                  },

                  new Apartment
                  {
                      Id = 3,
                      Price = 300,
                      NumOfRooms = 1,
                      FloorNo = 2,
                      Square = 35,
                      Description = "apartment with furniture and TV (students pls don't bother)",
                      Status = ApartmentStatus.ForRent,
                      ImageURL = "https://img09.cdnbor.uz/storage/uploads/listing_image/2020/12/19/5019614/1920x1080_resized/97a0ae6b2446f4c8f5a6e84e36e9f2e9.jpeg",
                      RegionId = 1

                  },

                   new Apartment
                   {
                       Id = 4,
                       Price = 35000,
                       NumOfRooms = 2,
                       FloorNo = 1,
                       Square = 50,
                       Description = "there are some old furniture in the apartment",
                       Status = ApartmentStatus.ForSale,
                       ImageURL = "https://img02.cdnbor.uz/storage/uploads/listing_image/2019/09/11/4093722/200x160_fitted/1bd6f2237bd96f65d11dd3d5e34bec23.jpg",
                       RegionId = 1

                   },
                    new Apartment
                    {
                        Id = 5,
                        Price = 40000,
                        NumOfRooms = 2,
                        FloorNo = 3,
                        Square = 60,
                        Description = "in good condition",
                        Status = ApartmentStatus.ForSale,
                        ImageURL = "https://img02.cdnbor.uz/storage/uploads/listing_image/2020/01/12/4337545/200x160_fitted/9ad824a18ce345550290c6c8783238e7.jpg",
                        RegionId = 1

                    },

                     new Apartment
                     {
                         Id = 6,
                         Price = 25000,
                         NumOfRooms = 1,
                         FloorNo = 1,
                         Square = 30,
                         Description = "For Sale asap",
                         Status = ApartmentStatus.ForSale,
                         ImageURL = "https://img07.cdnbor.uz/storage/uploads/listing_image/2019/09/06/4082046/200x160_fitted/5046b9d8413f72a3aad412db0fb7b737.jpg",
                         RegionId = 1

                     },
                     new Apartment
                     {
                         Id = 7,
                         Price = 250,
                         NumOfRooms = 1,
                         FloorNo = 9,
                         Square = 35,
                         Description = "in a good condition",
                         Status = ApartmentStatus.ForRent,
                         ImageURL = "https://img10.cdnbor.uz/storage/uploads/listing_image/2020/05/12/4533019/200x160_fitted/875eca3baaa10acde1afffa1d607a4ad.JPEG",
                         RegionId = 1

                     },
                      new Apartment
                      {
                          Id = 8,
                          Price = 55000,
                          NumOfRooms = 3,
                          FloorNo = 2,
                          Square = 90,
                          Description = "in a perfect condition",
                          Status = ApartmentStatus.ForSale,
                          ImageURL = "https://img06.cdnbor.uz/storage/uploads/listing_image/2021/01/03/5045061/200x160_fitted/a84ff6a169af313c467e8776b06f9abf.jpg",
                          RegionId = 1

                      },
                       new Apartment
                       {
                           Id = 9,
                           Price = 1000,
                           NumOfRooms = 2,
                           FloorNo = 1,
                           Square = 30,
                           Description = "apartment is for a long term rent only with contract",
                           Status = ApartmentStatus.ForSale,
                           ImageURL = "https://img06.cdnbor.uz/storage/uploads/listing_image/2021/02/18/5156013/200x160_fitted/f163967240f8715cbd98716b2f1118db.jpg",
                           RegionId = 1

                       },
                        new Apartment
                        {
                            Id = 10,
                            Price = 100000,
                            NumOfRooms = 4,
                            FloorNo = 3,
                            Square = 100,
                            Description = "Apartment with 4 bedrooms in a perfect condition in city center",
                            Status = ApartmentStatus.ForSale,
                            ImageURL = "https://img03.cdnbor.uz/storage/uploads/listing_image/2019/12/08/4282198/200x160_fitted/ca01a8611542d5a240e8c1870523195b.jpg",
                            RegionId = 1

                        }
                );
        }
    }
}
