using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Order1
        Address address1 = new Address("Paseo Alicia 2 Lot8", "Casili Hills Subd.", "Mandaue", "Philippines");
        Customer customer1 = new Customer("Lance Kervey Gerez", address1);
        List<Product> productsList1 = new List<Product>();

        Product Ranz901 = new Product("Mapple Hill Whole Milk 1L", "WholeMilkMH07", 6.59, 3);
        Product Ranz902 = new Product("AppleGate Organic Turkey Burgers", "TurkeyBurgersAG112", 12.49, 3);
        Product Ranz903 = new Product("HarmLess Harvest Coconut Water 355ml (Pack of 4)", "CoconutWaterHH912", 14.49, 8);

        productsList1.Add(Ranz901);
        productsList1.Add(Ranz902);
        productsList1.Add(Ranz903);

        Order order1 = new Order(productsList1, customer1);

        Console.WriteLine("Order Number: 1");
        order1.DisplayResults();
        Console.WriteLine();

        //Order2
        Address address2 = new Address("143 Street", "Provo", "UT 84150", "USA");
        Customer customer2 = new Customer("Janice A. Noble", address2);
        List<Product> productsList2 = new List<Product>();

        Product Ranz801 = new Product("365 by Whole foods Market", "BlackBeans365", 1.29, 5);
        Product Ranz802 = new Product("Annie's Cheddar Bunnies (Pack of 12)", "CheddarA12", 8.49, 1);
        Product Ranz803 = new Product("Poppi Root Beer", "RootBeerP", 2.22, 10);

        productsList2.Add(Ranz801);
        productsList2.Add(Ranz802);
        productsList2.Add(Ranz803);

        Order order2 = new Order(productsList2, customer2);

        Console.WriteLine("Order Number: 2");
        order2.DisplayResults();
        Console.WriteLine();

        //Order3
        Address address3 = new Address("2024 S 2025 W", "Salt Lake City", "UT 84150", "USA");
        Customer customer3 = new Customer("Gerry J. Brown", address3);
        List<Product> productsList3 = new List<Product>();

        Product Ranz701 = new Product("365 Extra Virgin Olive Oil 1L", "OliveOil365", 8.99, 3);
        Product Ranz702 = new Product("Organic Vegetable Tray", "VegetableTray222", 6.99, 4);
        Product Ranz703 = new Product("365 by Whole foods Market", "BlackBeans365", 1.29, 5);

        productsList3.Add(Ranz701);
        productsList3.Add(Ranz702);
        productsList3.Add(Ranz703);

        Order order3 = new Order(productsList3, customer3);

        Console.WriteLine("Order Number: 3");
        order3.DisplayResults();
        Console.WriteLine();
    }
}