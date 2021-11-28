using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductCoreService_DOTNET5.Models;

  public class Data
    {
        public static Task<List<Product>> Products = Task.Run(()=> new List<Product>
        {
            new Product { name = "SAMSUNG GALAXY S21 Ultra", category ="GSM", price = 10000 , discount = 5, quantity = 100, barcode = 12546358 },
            new Product { name = "REFRIGERATEUR SAMSUNG NO-FROST", category ="REFRIGIRATEUR", price = 7000 , discount = 10, quantity = 20, barcode = 12454784 },
            new Product { name = "Easy T-Shirt Homme", category ="FASHION", price = 100 , discount = 1, quantity = 63, barcode = 25458778 },
            new Product { name = "New Balance Basket Homme", category ="FASHION", price = 300 , discount = 5, quantity = 15, barcode = 457887558 },
            new Product { name = "L'Oréal Paris Fond de Teint", category ="BEAUTE", price = 600 , discount = 4, quantity = 70, barcode = 987588 }
            //... Vous pouvez en ajouter d'autres pour fiabiliser les résultats de vos tests
        });
    }
