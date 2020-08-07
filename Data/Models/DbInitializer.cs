using SalesTaxApp.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using System;

namespace SalesTaxApp.Data.Models
{
    public class DbInitializer
    {
        public static void Seed(IServiceProvider applicationBuilder)
        {
            ApplicationContext context =
                applicationBuilder.GetRequiredService<ApplicationContext>();


            if (!context.Products.Any())
            {
                context.AddRange
                (
                    new Product
                    {
                        Name = "Book",
                        Price = 12.49M,
                        ShortDescription = "PERCY JACKSON'S GREEK GODS is thorough, easy to read, and high on entertainment value.",
                        LongDescription = "After exploring how the Greeks thought the world began in a chapter entitled 'The Beginning and Stuff,' the Titans appear, followed by the Olympians, who rage a battle royale for dominance. Then each of the 12 major Greek gods gets his or her own chapter. Percy refuses to start with Zeus, claiming he has a big enough ego already, so he goes with the order in which the gods were born. Each chapter includes full-color illustrations and Percy's take on each god's origins, what they're most known for, and stories of them interacting with mortals, looking for love, and smiting those who wronged them.",
                        ImageUrl = "../../images/percy-jacksons-greek-gods-resized-opt.jpg",
                        IsFood = false,
                        IsImport = false,
                        IsMedical = false,
                        ImageThumbnailUrl = "../../images/percy-jacksons-greek-gods-resized-opt-s.jpg"
                    },

                    new Product
                    {
                        Name = "Music CD",
                        Price = 14.99M,
                        ShortDescription = "The Beatles Sgt. Pepper's Lonely Hearts Club Band CD.",
                        LongDescription = "Rolling Stone, a few years back, listed the Top 500 albums of all time. Not surprisingly, The Beatles had most of their albums make the list. Of the Top 5, Rubber Soul was #5 and Revolver ranked #3.",
                        ImageUrl = "../../images/beatles-sargent-peppers.jpg",
                        IsFood = false,
                        IsImport = false,
                        IsMedical = false,
                        ImageThumbnailUrl = "../../images/beatles-sargent-peppers-s.jpg"
                    },
                    
                    new Product
                    {
                        Name = "Chocolate Bar",
                        Price = 0.85M,
                        ShortDescription = "3 Musketeers Candy Bar 1.92 oz. The perfect candy bar.",
                        LongDescription = "3 Musketeers with it's delicious chocolate covered fluffy nougat is the perfect candy bar when you don't want something so heavy. Experience the lighter way to enjoy chocolate!",
                        ImageUrl = "../../images/3-musketeers.jpg",
                        IsFood = true,
                        IsImport = false,
                        IsMedical = false,
                        ImageThumbnailUrl = "../../images/3-musketeers-s.jpg"
                    },
                    
                    new Product
                    {
                        Name = "Imported box of chocolates",
                        Price = 11.25M,
                        ShortDescription = "Luxury imported box of chocolates.",
                        LongDescription = "Some long description goes here",
                        ImageUrl = "../../images/imported-chocolates-1.jpg",
                        IsFood = true,
                        IsImport = true,
                        IsMedical = false,
                        ImageThumbnailUrl = "../../images/imported-chocolates-1-s.jpg"
                    },
                    
                    new Product
                    {
                        Name = "Imported box of chocolates",
                        Price = 10.00M,
                        ShortDescription = "Imported Swiss Chocolate Box – (16 Pcs)",
                        LongDescription = "Some long description goes here",
                        ImageUrl = "../../images/imported-chocolates-premium.jpg",
                        IsFood = true,
                        IsImport = true,
                        IsMedical = false,
                        ImageThumbnailUrl = "../../images/imported-chocolates-premium-s.jpg"
                    },

                    new Product
                    {
                        Name = "Imported bottle of perfume",
                        Price = 47.50M,
                        ShortDescription = "Eau de parfum for men and women.",
                        LongDescription = "Featuring a unique citrus-laced scent that is both refreshing and provocative, ck one by Calvin Klein is a veau de parfum for men and women.",
                        ImageUrl = "../../images/expensive-imported-perfume.jpg",
                        IsFood = false,
                        IsImport = true,
                        IsMedical = false,
                        ImageThumbnailUrl = "../../images/expensive-imported-perfume-s.jpg"
                    },

                    new Product
                    {
                        Name = "Imported bottle of perfume",
                        Price = 27.99M,
                        ShortDescription = "This one is less expensive.",
                        LongDescription = "Some long description.",
                        ImageUrl = "../../images/cheap-imported-perfume.jpg",
                        IsFood = false,
                        IsImport = true,
                        IsMedical = false,
                        ImageThumbnailUrl = "../../images/cheap-imported-perfume-s.jpg"
                    },

                    new Product
                    {
                        Name = "Bottle of perfume",
                        Price = 18.99M,
                        ShortDescription = "Happy eau de parfum spray for women.",
                        LongDescription = "This scent offers a juicy combination of notes that's perfect for everyday wear, including a top-note combination of plum and Indian mandarin that surrounds a heart of freesia and lily-of-the-valley to leave you feeling as fresh as the morning dew. The scent is grounded in a mimosa base for a hauntingly flirty dry down.",
                        ImageUrl = "../../images/happy-perfume.jpg",
                        IsFood = false,
                        IsImport = false,
                        IsMedical = false,
                        ImageThumbnailUrl = "../../images/happy-perfume-s.jpg"
                    },
                    
                    new Product
                    {
                        Name = "Packet of headache pills",
                        Price = 9.75M,
                        ShortDescription = "Relieve your headache.",
                        LongDescription = "Some long description.",
                        ImageUrl = "../../images/headache-pills.jpg",
                        IsFood = false,
                        IsImport = false,
                        IsMedical = true,
                        ImageThumbnailUrl = "../../images/headache-pills-s.jpg"
                    }
                );
            }

            context.SaveChanges();
        }

    }
}

