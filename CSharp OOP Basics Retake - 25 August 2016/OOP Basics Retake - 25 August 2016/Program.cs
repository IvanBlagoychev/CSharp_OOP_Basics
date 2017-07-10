using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Program
{
    static void Main()
    {
        var input = Console.ReadLine();
        CleansingCenter cleansingCenter = null;
        AdoptionCenter adoptionCenter = null;
        List<AdoptionCenter> adoptionCenters = new List<AdoptionCenter>();
        List<CleansingCenter> cleansingCenters = new List<CleansingCenter>();

        while (input != "Paw Paw Pawah")
        {
            var tokens = input.Split(new char[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries);

            switch (tokens[0])
            {
                case "RegisterCleansingCenter":
                    RegisterClensingCenter(tokens[1], cleansingCenter, cleansingCenters);
                    break;
                case "RegisterAdoptionCenter":
                    RegisterAdoptionCenter(tokens[1], adoptionCenter, adoptionCenters);
                    break;
                case "RegisterDog":
                    RegisterNewDog(tokens, adoptionCenters);
                    break;
                case "RegisterCat":
                    RegisterNewCat(tokens, adoptionCenters);
                    break;
                case "SendForCleansing":
                    SendForCleansing(adoptionCenters, cleansingCenters, tokens[1], tokens[2]);
                    break;
                case "Cleanse":
                    Cleanse(tokens[1], cleansingCenters);
                    break;
                case "Adopt":
                    var desiredCenter = adoptionCenters.FirstOrDefault(x => x.Name == tokens[1]);
                    desiredCenter.AdoptAnimals();
                    break;
                default: break;
            }
            input = Console.ReadLine();
        }

        var sb = new StringBuilder();

        List<string> cleansedAnimals = new List<string>();
        List<string> adoptedAnimals = new List<string>();

        foreach (CleansingCenter c in cleansingCenters)
        {
            foreach (Animal animal in c.CleansedAnimals)
            {
                cleansedAnimals.Add(animal.Name);
            }
        }
        foreach (AdoptionCenter c in adoptionCenters)
        {
            foreach (Animal a in c.AdoptedAnimals)
            {
                adoptedAnimals.Add(a.Name);
            }
        }

        sb.AppendLine("Paw Incorporative Regular Statistics")
            .AppendLine($"Adoption Centers: {adoptionCenters.Count}")
            .AppendLine($"Cleansing Centers: {cleansingCenters.Count}");

        if (adoptedAnimals.Count == 0) sb.AppendLine("Adopted Animals: None");
        else sb.AppendLine($"Adopted Animals: {string.Join(", ", adoptedAnimals.OrderBy(a => a))}");

        if (cleansedAnimals.Count == 0) sb.AppendLine("Cleansed Animals: None");
        else sb.AppendLine($"Cleansed Animals: {string.Join(", ", cleansedAnimals.OrderBy(a => a))}");

        sb.AppendLine($"Animals Awaiting Adoption: {adoptionCenters.Sum(s => s.AnimalsForAdoption.Count)}")
        .Append($"Animals Awaiting Cleansing: {cleansingCenters.Sum(s => s.StoredAnimals.Count)}");
        Console.WriteLine(sb);
    }

    private static void Cleanse(string centerName, List<CleansingCenter> centers)
    {
        var desiredCenter = centers.FirstOrDefault(x => x.Name == centerName);
        desiredCenter.CleanseAnimals();
    }

    private static void SendForCleansing(List<AdoptionCenter> adoptionCenters, List<CleansingCenter> cleansingCenters, string aCenterName, string cCenterName)
    {
        var Acenter = adoptionCenters.FirstOrDefault(x => x.Name == aCenterName);
        var Ccenter = cleansingCenters.FirstOrDefault(x => x.Name == cCenterName);
        Acenter.SendForCleanse(Ccenter);
    }

    private static void RegisterNewCat(string[] catData, List<AdoptionCenter> adoptionCenters)
    {
        var name = catData[1];
        var age = int.Parse(catData[2]);
        var intelligenceCoef = int.Parse(catData[3]);
        var adoptionCenterName = catData[4];
        var desiredCenter = adoptionCenters.FirstOrDefault(x => x.Name == adoptionCenterName);
        Animal newCat = new Cat(name, age, intelligenceCoef, desiredCenter);
        desiredCenter.UnclensedAnimals.Add(newCat);
    }

    private static void RegisterNewDog(string[] dogData, List<AdoptionCenter> centers)
    {
        var name = dogData[1];
        var age = int.Parse(dogData[2]);
        var learnedCommands = int.Parse(dogData[3]);
        var adoptionCenterName = dogData[4];
        var desiredCenter = centers.FirstOrDefault(x => x.Name == adoptionCenterName);
        Animal newDog = new Dog(name, age, learnedCommands, desiredCenter);
        desiredCenter.UnclensedAnimals.Add(newDog);
    }

    private static void RegisterAdoptionCenter(string name, AdoptionCenter newAdoptionCenter, List<AdoptionCenter> centers)
    {
        newAdoptionCenter = new AdoptionCenter(name);
        centers.Add(newAdoptionCenter);
    }

    private static void RegisterClensingCenter(string name, CleansingCenter cleansingCenter, List<CleansingCenter> centers)
    {
        cleansingCenter = new CleansingCenter(name);
        centers.Add(cleansingCenter);
    }
}