﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PZCheeseria.Domain.Entities;

namespace PzCheeseria.Persistence.Configurations;

public  class CheeseConfiguration:IEntityTypeConfiguration<Cheese>
{

    public void Configure(EntityTypeBuilder<Cheese> builder)
    {
        builder.HasKey(m => m.Id);
        builder.Property(m => m.PricePerKilo)
            .IsRequired();
        builder.Property(m => m.ImageName)
            .IsRequired().HasMaxLength(100);
        builder.Property(m => m.Description).IsRequired().HasMaxLength(1000);
        builder.Property(m => m.Name).IsRequired().HasMaxLength(100);
        builder.HasOne(m => m.Colour);
        builder.Property(m => m.CreatedOn).IsRequired();
    }

}