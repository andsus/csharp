/*
using System;
using System.Collections.Generic;
public class Robot
{
    private readonly Random rand = new Random();
    public string Name { get; private set; }

    private static readonly HashSet<string> knownNames = new HashSet<string>();
    public Robot() => Reset();

    public void Reset()
    {   
        do 
        {
            Name = GenerateSerialName();
        } while (knownNames.Contains(Name));

         knownNames.Add(Name);        
    }


    private string GenerateSerialName() 
    {
        return string.Format("{0}{1}{2:000}",
            GetRandomAlpha(), GetRandomAlpha(), GetRandomInt()
        );

    }
    // Random alphabet A .. Z
    private char GetRandomAlpha() =>  (char)('A' + rand.Next(26));
    
    // Random 3 digit int
    private int GetRandomInt() => rand.Next(1000);
    


}
*/

// class RandomSequence {

//   int actual;
//   static final int M = (1<<31) -1;

//   public RandomSequence(int seed) {
//     this.actual = seed
//   }

//   public int next() {
//     return this.actual = (16807 * this.actual) % RandomSequence.M
//   }

// }

// usage
//...
// List<int> awesomeList = new List<int>();
// RandomSequence sq = new RandomSequence( RandomUtil.getRandomPositiveIntSmallerThanM() );
// for(int i = 0; i < n; i++) {
//   awesomeList.add(sq.next());
// }

