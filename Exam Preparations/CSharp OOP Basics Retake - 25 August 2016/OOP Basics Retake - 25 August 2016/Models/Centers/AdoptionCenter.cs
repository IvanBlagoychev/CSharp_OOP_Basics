using System.Collections.Generic;

public class AdoptionCenter : Center
{
    private List<Animal> unclensedAnimals;
    private List<Animal> animalsForAdoption;
    private List<Animal> adoptedAnimals;

    public AdoptionCenter(string name) : base(name)
    {
        this.AnimalsForAdoption = new List<Animal>();
        this.UnclensedAnimals = new List<Animal>();
        this.AdoptedAnimals = new List<Animal>();
    }

    public List<Animal> UnclensedAnimals
    {
        get => this.unclensedAnimals;
        set => this.unclensedAnimals = value;
    }
    public List<Animal> AnimalsForAdoption
    {
        get => this.animalsForAdoption;
        set => this.animalsForAdoption = value;
    }

    public void SendForCleanse(CleansingCenter c)
    {
        this.UnclensedAnimals.ForEach(a=>c.StoredAnimals.Add(a));
        c.CenterToReturn = this;
        this.UnclensedAnimals.Clear();
    }
    public List<Animal> AdoptedAnimals
    {
        get => this.adoptedAnimals;
        set => this.adoptedAnimals = value;
    }

    public void AdoptAnimals()
    {
        foreach (Animal a in AnimalsForAdoption)
        {
            if (a.IsClensed) this.AdoptedAnimals.Add(a);
        }
        foreach (Animal a in this.AdoptedAnimals)
        {
            if (this.AnimalsForAdoption.Contains(a))
            {
                this.animalsForAdoption.Remove(a);
            }
        }
    }

}