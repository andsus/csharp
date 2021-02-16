using System;
using System.Linq;
public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        if (firstStrand.Length != secondStrand.Length) {
            throw new ArgumentException("FirstStrand and SecondStrand not equal in length");
        }

        return firstStrand
                .Zip(secondStrand, (first,second) => first == second ? 0 : 1 )
                .Sum();
        
    }
}