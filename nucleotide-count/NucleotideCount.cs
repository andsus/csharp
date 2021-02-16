using System;
using System.Collections.Generic;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        var nuclMap = new Dictionary<char, int>() { 
            {'A', 0}, {'C', 0}, {'G',0}, {'T',0}
        };

        foreach (char c in sequence) {
            if (nuclMap.ContainsKey(c)) {
                nuclMap[c] += 1;
            } else {
                throw new ArgumentException($"Nucleoid {c} not found ");
            }
        }
        
        return nuclMap;
    }
}