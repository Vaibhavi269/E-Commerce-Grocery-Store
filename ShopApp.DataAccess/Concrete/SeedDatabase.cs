using Microsoft.EntityFrameworkCore;
using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShopApp.DataAccess.Concrete
{
    public static class SeedDatabase
    {
        public static void Seed()
        {
            var context = new ShopContext();

            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Categories.Count() == 0)
                {
                    context.Categories.AddRange(Categories);
                }

                if (context.Products.Count() == 0)
                {
                    context.Products.AddRange(Products);
                    context.AddRange(ProductCategory);
                }

                context.SaveChanges();
            }
        }

        private static Category[] Categories = {
            new Category() { Name="Fruit & Vegetables"},
            new Category() { Name="Bakery"},
            new Category() { Name="Dairy"}
        };

        private static Product[] Products =
        {
            new Product(){ Name="Solaray Beta Glucan", Price=20, ImageUrl="1.jpg", Description="<p>Beta Glucan is an insoluble fiber that has been isolated from the cell wall of baker''s yeast that consists of beta 1,3 and 1,6 linkages. </p> <p> *These statements have not been evaluated by the Food and Drug Administration. This product is not intended to diagnose, treat, cure, or prevent any disease. </p>"},
            new Product(){ Name="Solaray Bitter Orange", Price=30, ImageUrl="2.jpg", Description="<p>For thousands of years, immature bitter orange has been used in Chinese Traditional Medicine.</p> <p> *These statements have not been evaluated by the Food and Drug Administration. This product is not intended to diagnose, treat, cure, or prevent any disease. </p>"},
            new Product(){ Name="Solaray Burdock", Price=40, ImageUrl="3.jpg", Description="<p>Lycopene, a member of the carotenoid family, is a potent antioxidant. Lycopene is intended to provide nutritive support for prostate and heart health.</p> <p> *These statements have not been evaluated by the Food and Drug Administration. This product is not intended to diagnose, treat, cure, or prevent any disease. </p>"},
            new Product(){ Name="Country Life L-Methionine", Price=10, ImageUrl="4.jpg", Description="<p>Zinc is a trace element which is essential for normal growth, development of the reproductive organs, normal functioning of the prostate gland, healing of wounds, and the manufacture of proteins and nucleic acids (the building blocks for RNA and DNA.) It is also necessary for over 100 different enzyme systems in the body. </p> <p> *These statements have not been evaluated by the Food and Drug Administration. This product is not intended to diagnose, treat, cure, or prevent any disease. </p>"},
            new Product(){ Name="Zand Insure HerbaLozenge", Price=10, ImageUrl="5.jpg", Description="<p>Target-Mins are made with specific free-form amino acids and uses a calcium-to-phosphorus and calcium-to-magnesium ratio of 2:1 to support calcium utilization. Supports body availability of calcium..</p><ul><li>Certified Gluten Free</li><li>Formulated to Maximize Calcium Absorption</li><li>Kosher</li><li>Vegan</li></ul> <p> *These statements have not been evaluated by the Food and Drug Administration. This product is not intended to diagnose, treat, cure, or prevent any disease. </p>"},
            new Product(){ Name="Nature's Life  Lycopene", Price=40, ImageUrl="6.jpg", Description="<p>Some research indicates that Calcium Bis-Glycinate is the most absorbable form of Calcium.&nbsp; Tests show that this form of Calcium is 205 times more soluble than Calcium Citrate.&nbsp; In human studies, Calcium Bis-Glycinate was shown to be 1.8 times (180%) more absorbable than Calcium Citrate and 21% better than Calcium Citrate Malate.</p> <p> *These statements have not been evaluated by the Food and Drug Administration. This product is not intended to diagnose, treat, cure, or prevent any disease. </p>"},
            new Product(){ Name="Source Naturals OptiZinc", Price=50, ImageUrl="7.jpg", Description="<p>The roots of lomatium (Lomatium dissectum) were among the most important of indigenous herbs of the Pacific Northwest for supporting healthy immune and respiratory systems.</p> <p> *These statements have not been evaluated by the Food and Drug Administration. This product is not intended to diagnose, treat, cure, or prevent any disease. </p>"},
            new Product(){ Name="Pure Vegan Gluten Free", Price=30, ImageUrl="8.jpg", Description="<p>For thousands of years, immature bitter orange has been used in Chinese Traditional Medicine.</p> <p> *These statements have not been evaluated by the Food and Drug Administration. This product is not intended to diagnose, treat, cure, or prevent any disease. </p>"},
            new Product(){ Name="Aura Cacia Amber Mist", Price=40, ImageUrl="9.jpg", Description="<p>Lycopene, a member of the carotenoid family, is a potent antioxidant. Lycopene is intended to provide nutritive support for prostate and heart health.</p> <p> *These statements have not been evaluated by the Food and Drug Administration. This product is not intended to diagnose, treat, cure, or prevent any disease. </p>"},
            new Product(){ Name="Natural Horny Goat Weed™ 500 ", Price=10, ImageUrl="10.jpg", Description="<p>Zinc is a trace element which is essential for normal growth, development of the reproductive organs, normal functioning of the prostate gland, healing of wounds, and the manufacture of proteins and nucleic acids (the building blocks for RNA and DNA.) It is also necessary for over 100 different enzyme systems in the body. </p> <p> *These statements have not been evaluated by the Food and Drug Administration. This product is not intended to diagnose, treat, cure, or prevent any disease. </p>"},
            new Product(){ Name="Nature Made Vitamin ", Price=10, ImageUrl="11.jpg", Description="<p>Target-Mins are made with specific free-form amino acids and uses a calcium-to-phosphorus and calcium-to-magnesium ratio of 2:1 to support calcium utilization. Supports body availability of calcium..</p><ul><li>Certified Gluten Free</li><li>Formulated to Maximize Calcium Absorption</li><li>Kosher</li><li>Vegan</li></ul> <p> *These statements have not been evaluated by the Food and Drug Administration. This product is not intended to diagnose, treat, cure, or prevent any disease. </p>"},
            new Product(){ Name="Biochem Sports Carb ", Price=40, ImageUrl="12.jpg", Description="<p>Some research indicates that Calcium Bis-Glycinate is the most absorbable form of Calcium.&nbsp; Tests show that this form of Calcium is 205 times more soluble than Calcium Citrate.&nbsp; In human studies, Calcium Bis-Glycinate was shown to be 1.8 times (180%) more absorbable than Calcium Citrate and 21% better than Calcium Citrate Malate.</p> <p> *These statements have not been evaluated by the Food and Drug Administration. This product is not intended to diagnose, treat, cure, or prevent any disease. </p>"},
            new Product(){ Name="Krill Oil Softgels 500mg", Price=50, ImageUrl="13.jpg", Description="<p>The roots of lomatium (Lomatium dissectum) were among the most important of indigenous herbs of the Pacific Northwest for supporting healthy immune and respiratory systems.</p> <p> *These statements have not been evaluated by the Food and Drug Administration. This product is not intended to diagnose, treat, cure, or prevent any disease. </p>"}
        };


        private static ProductCategory[] ProductCategory =
        {
            new ProductCategory() { Product= Products[0],Category= Categories[0]},
            new ProductCategory() { Product= Products[1],Category= Categories[2]},
            new ProductCategory() { Product= Products[2],Category= Categories[0]},
            new ProductCategory() { Product= Products[3],Category= Categories[1]},
            new ProductCategory() { Product= Products[4],Category= Categories[0]},
            new ProductCategory() { Product= Products[5],Category= Categories[2]},
            new ProductCategory() { Product= Products[6],Category= Categories[1]},
            new ProductCategory() { Product= Products[7],Category= Categories[2]},
            new ProductCategory() { Product= Products[8],Category= Categories[0]},
            new ProductCategory() { Product= Products[9],Category= Categories[1]},
            new ProductCategory() { Product= Products[10],Category= Categories[0]},
            new ProductCategory() { Product= Products[11],Category= Categories[2]},
            new ProductCategory() { Product= Products[12],Category= Categories[1]}
        };
    }
}
