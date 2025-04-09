using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp14.Product;

namespace ConsoleApp14;

public class Store
{

    Product[] products = new Product[0];
    public void AddProduct(Product product)
    {
        Array.Resize(ref products, products.Length + 1);
        products[^1] = product;
        Console.WriteLine("elave olundu");
    }



    public Product GetProduct(int no)
    {
        foreach (Product p in products)
        {
            if (p.No == no)
            {
                return p;
            }
        }
        return default;
    }

    public Product[] FilterProductsByType(Profession prof)
    {
        Product[] pro = new Product[0];

        foreach (Product p in products)
        {
            if (p.profession == prof)
            {
                Array.Resize(ref pro, pro.Length + 1);
                products[^1] = p;
            }
        }
        return pro;
    }

    public Product[] FilterProductByName(string name)
    {
        Product[] pro = new Product[0];

        foreach (Product p in products)
        {
            if (p.Name == name)
            {
                Array.Resize(ref pro, pro.Length + 1);
                products[^1] = p;
            }
        }
        return pro;
    }












}

