using System;
using System.Linq;
public enum Allergen
{
    Eggs = 1,
    Peanuts = 2,
    Shellfish = 4,
    Strawberries = 8,
    Tomatoes = 16,
    Chocolate = 32,
    Pollen = 64,
    Cats = 128
}

public class Allergies
{
    private readonly Allergen _allergens;
    public Allergies(int mask)
    {
        _allergens = (Allergen)mask;
    }

    public bool IsAllergicTo(Allergen allergen) =>
        (allergen & _allergens) == allergen;

    public Allergen[] List()
    {
        return Enum.GetValues(typeof(Allergen))
            .Cast<Allergen>()
            .Where(IsAllergicTo)
            .ToArray();
    }
}