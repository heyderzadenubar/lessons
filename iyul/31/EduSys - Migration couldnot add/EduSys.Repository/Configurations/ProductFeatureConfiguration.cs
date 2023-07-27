﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduSys.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EduSys.Repository.Configurations
{
    public class ProductFeatureConfiguration : IEntityTypeConfiguration<ProductFeature>
    {
        public void Configure(EntityTypeBuilder<ProductFeature> builder)
        {
            builder.HasKey(x => x.Id);  
            builder.Property(x=>x.Id).UseIdentityColumn();

            builder.HasOne(x=>x.Product).WithOne(x=>x.ProductFeature).HasForeignKey<ProductFeature>(x=>x.ProductId);
        }
    }
}
