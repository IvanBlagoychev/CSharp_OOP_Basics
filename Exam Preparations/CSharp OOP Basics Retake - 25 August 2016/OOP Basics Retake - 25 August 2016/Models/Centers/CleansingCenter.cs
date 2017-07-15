using System.Collections.Generic;

public class CleansingCenter : Center
{
    private AdoptionCenter centerToReturn;
    private List<Animal> storedAnimals;
    private List<Animal> clensedAnimals;

    public CleansingCenter(string name) : base(name)
    {
        this.StoredAnimals = new List<Animal>();
        this.CleansedAnimals = new List<Animal>();
    }

    public AdoptionCenter CenterToReturn
    {
        get => this.centerToReturn;
        set => this.centerToReturn = value;
    }

    public List<Animal> StoredAnimals
    {
        get => this.storedAnimals;
        set => this.storedAnimals = value;
    }

    public List<Animal> CleansedAnimals
    {
        get => this.clensedAnimals;
        set => this.clensedAnimals = value;
    }
    public void CleanseAnimals()
    {
        foreach (Animal animal in this.StoredAnimals)
        {
            animal.IsClensed = true;
            this.CleansedAnimals.Add(animal);
            AdoptionCenter animalOriginCenter = animal.OriginCenter;
            this.centerToReturn = animalOriginCenter;
            centerToReturn.AnimalsForAdoption.Add(animal);
        }
        this.StoredAnimals.Clear();
    }
}