using System;
using System.Collections.Generic;

public static class Extensions
{
    public static Random rng = new Random();
    
    public static Queue<Card> Shuffle(this List<Card> list)
    {
        Queue<Card> queue = new Queue<Card>();
        int n = list.Count;  
        while (n > 1) {  
            n--;  
            int k = rng.Next(n + 1);  
            var value = list[k];  
            list[k] = list[n];  
            list[n] = value;  
        }

        return queue;
    }
}