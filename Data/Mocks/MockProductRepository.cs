using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesTaxApp.Data.Interfaces;
using SalesTaxApp.Data.Models;

namespace SalesTaxApp.Data.Mocks
{
    public class MockProductRepository : IProductRepository
    {
        
        public IEnumerable<Product> Products
        {
            get
            {
                return new List<Product>
                {
                //Book at 12.49
                //Music CD at 14.99
                //Chocolate bar at 0.85

                //Imported box of chocolates at 11.25
                //Imported box of chocolates at 10.00
                //Imported bottle of perfume at 27.99
                //Imported bottle of perfume at 47.50

                //Bottle of perfume at 18.99
                //Packet of headache pills at 9.75

                    new Product {
                        Name = "Book",
                        Price = 12.49M, 
                        ShortDescription = "PERCY JACKSON'S GREEK GODS is thorough, easy to read, and high on entertainment value.",
                        LongDescription = "After exploring how the Greeks thought the world began in a chapter entitled 'The Beginning and Stuff,' the Titans appear, followed by the Olympians, who rage a battle royale for dominance. Then each of the 12 major Greek gods gets his or her own chapter. Percy refuses to start with Zeus, claiming he has a big enough ego already, so he goes with the order in which the gods were born. Each chapter includes full-color illustrations and Percy's take on each god's origins, what they're most known for, and stories of them interacting with mortals, looking for love, and smiting those who wronged them.",
                        ImageUrl = "../../images/percy-jacksons-greek-gods-resized-opt.jpg",
                        IsFood = false,
                        IsImport = false,
                        ImageThumbnailUrl = "../../images/percy-jacksons-greek-gods-resized-opt-s.jpg"
                    },
                    
                    new Product {
                        Name = "Music CD",
                        Price = 14.99M, 
                        ShortDescription = "The Beatles Sgt. Pepper's Lonely Hearts Club Band CD.",
                        LongDescription = "Rolling Stone, a few years back, listed the Top 500 albums of all time. Not surprisingly, The Beatles had most of their albums make the list. Of the Top 5, Rubber Soul was #5 and Revolver ranked #3.",
                        ImageUrl = "../../images/beatles-sargent-peppers.jpg",
                        IsFood = false,
                        IsImport = false,
                        ImageThumbnailUrl = "../../images/beatles-sargent-peppers-s.jpg"
                    },
                    
                    new Product {
                        Name = "Chocolate Bar",
                        Price = 0.85M, 
                        ShortDescription = "3 Musketeers Candy Bar 1.92 oz.",
                        LongDescription = "3 Musketeers with it's delicious chocolate covered fluffy nougat is the perfect candy bar when you don't want something so heavy. Experience the lighter way to enjoy chocolate!",
                        ImageUrl = "../../images/3-musketeers.jpg",
                        IsFood = true,
                        IsImport = false,
                        ImageThumbnailUrl = "../../images/3-musketeers-s.jpg"
                    },
                    
                    new Product
                    {
                        Name = "Imported box of chocolates - Premium",
                        Price = 11.25M,
                        ShortDescription = "Luxury imported box of chocolates.",
                        LongDescription = "Some long description goes here",
                        ImageUrl = "../../images/imported-chocolates-1.jpg",
                        IsFood = true,
                        IsImport = true,
                        ImageThumbnailUrl = "../../images/imported-chocolates-1-s.jpg"
                    },
                    
                    new Product
                    {
                        Name = "Imported box of chocolates - Standard",
                        Price = 10.00M,
                        ShortDescription = "Imported Swiss Chocolate Box – (16 Pcs)",
                        LongDescription = "Some long description goes here",
                        ImageUrl = "../../images/imported-chocolates-1.jpg",
                        IsFood = true,
                        IsImport = true,
                        ImageThumbnailUrl = "../../images/imported-chocolates-1-s.jpg"
                    },

                    new Product {
                        Name = "Imported bottle of perfume - Premium",
                        Price = 47.50M,
                        ShortDescription = "Eau de parfum for men and women.",
                        LongDescription = "Featuring a unique citrus-laced scent that is both refreshing and provocative, ck one by Calvin Klein is a veau de parfum for men and women.",
                        ImageUrl = "../../images/expensive-imported-perfume.jpg",
                        IsFood = false,
                        IsImport = true,
                        ImageThumbnailUrl = "../../images/expensive-imported-perfume-s.jpg"
                    },

                    new Product {
                        Name = "Imported bottle of perfume - Standard",
                        Price = 27.99M,
                        ShortDescription = "This one is less expensive.",
                        LongDescription = "Some long description.",
                        ImageUrl = "../../images/cheap-imported-perfume.jpg",
                        IsFood = false,
                        IsImport = true,
                        ImageThumbnailUrl = "../../images/cheap-imported-perfume-s.jpg"
                    },

                    new Product {
                        Name = "Bottle of perfume",
                        Price = 18.99M,
                        ShortDescription = "Happy eau de parfum spray for women.",
                        LongDescription = "This scent offers a juicy combination of notes that's perfect for everyday wear, including a top-note combination of plum and Indian mandarin that surrounds a heart of freesia and lily-of-the-valley to leave you feeling as fresh as the morning dew. The scent is grounded in a mimosa base for a hauntingly flirty dry down.",
                        ImageUrl = "../../images/happy-perfume.jpg",
                        IsFood = false,
                        IsImport = false,
                        ImageThumbnailUrl = "../../images/happy-perfume-s.jpg"
                    },
                    
                    new Product {
                        Name = "Packet of headache pills",
                        Price = 9.75M,
                        ShortDescription = "Relieve your headache.",
                        LongDescription = "Some long description.",
                        ImageUrl = "../../images/headache-pills.jpg",
                        IsFood = false,
                        IsImport = false,
                        ImageThumbnailUrl = "../../images/headache-pills-s.jpg"
                    }
                };
            }
        }
        //public IEnumerable<Product> PreferredProducts { get; }
        public Product GetProductById(int productId)
        {
            throw new NotImplementedException();
        }

    }
}
