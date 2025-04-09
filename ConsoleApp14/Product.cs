using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14;

public class Product
{
    private static int _no;
    public int No;

    public string Name;
	private double price;
    public Profession profession;
    public double Price
    {
		get { return price; }
		
        set
        { 
            if (value > 0)
            {
                price = value;
            }
        }
	}

    public Product(string name, double price,Profession profession)
    {
        _no++;
        No=_no;
        Name = name;
        Price = price;
        this.profession = profession;
    }
    public enum Profession
    {
        Baker, 
        Drink,
        Meat, 
        Diary
    }
}
