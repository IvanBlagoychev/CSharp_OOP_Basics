using System;
using System.Collections.Generic;
using System.Linq;

public class Shopping
{
    static void Main()
    {
        var people = new List<Person>();
        var products = new List<Product>();

        try
        {
            var peopleInput = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var person in peopleInput)
            {
                var personInfo = person.Split(new[] { '=' }, StringSplitOptions.RemoveEmptyEntries);

                var newPerson = new Person(personInfo[0], decimal.Parse(personInfo[1]));
                people.Add(newPerson);
            }

            var productInput = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var product in productInput)
            {
                var productInfo = product.Split(new[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
                var newProduct = new Product(productInfo[0], decimal.Parse(productInfo[1]));
                products.Add(newProduct);
            }

            var input = string.Empty;
            while ((input = Console.ReadLine()) != "END")
            {
                var tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var currentPerson = people.First(p => p.Name == tokens[0]);
                var currentProduct = products.First(p => p.Name.Equals(tokens[1]));

                if (currentPerson.Money >= currentProduct.Cost)
                {
                    Console.WriteLine($"{currentPerson.Name} bought {currentProduct.Name}");
                    currentPerson.Money -= currentProduct.Cost;
                    currentPerson.BagOfProducts.Add(currentProduct);
                }
                else
                {
                    Console.WriteLine($"{currentPerson.Name} can't afford {currentProduct.Name}");
                }
            }


            foreach (Person p in people)
            {
                if (p.BagOfProducts.Count == 0)
                {
                    Console.WriteLine($"{p.Name} - Nothing bought");
                }
                else
                {
                    Console.WriteLine($"{p.Name} - {string.Join(", ", p.BagOfProducts.Select(n => n.Name))}");
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return;
        }

    }
}