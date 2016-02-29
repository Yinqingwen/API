using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using API.Models;

namespace API.Migrations
{
    [DbContext(typeof(APIContext))]
    [Migration("20160229090329_20160229")]
    partial class _20160229
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("API.Models.City", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CityCode")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 6);

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 20);

                    b.Property<DateTime>("CreateDate");

                    b.Property<bool>("InUse");

                    b.Property<DateTime>("LastUpdateDate");

                    b.Property<string>("Remark1");

                    b.Property<string>("Remark2");

                    b.Property<string>("Remark3");

                    b.HasKey("ID");
                });

            modelBuilder.Entity("API.Models.Site", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<long>("CityID");

                    b.Property<DateTime>("CreateTime");

                    b.Property<bool>("InUse");

                    b.Property<DateTime>("LastUpdateTime");

                    b.Property<double>("Latitude");

                    b.Property<double>("Longitude");

                    b.Property<string>("MobileNumber");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("PostCode")
                        .IsRequired();

                    b.Property<string>("Remake1");

                    b.Property<string>("Remake2");

                    b.Property<string>("Remake3");

                    b.Property<string>("SiteCode")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 6);

                    b.Property<string>("SiteName")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 20);

                    b.HasKey("ID");
                });
        }
    }
}
