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


    private string GenerateSerialName() => 
        string.Format("{0}{1}{2:000}",
            GetRandomAlpha(), GetRandomAlpha(), GetRandomInt());
       
    // Random alphabet A .. Z
    private char GetRandomAlpha() =>  (char)('A' + rand.Next(26));
    
    // Random 3 digit int
    private int GetRandomInt() => rand.Next(1000);
    


}


