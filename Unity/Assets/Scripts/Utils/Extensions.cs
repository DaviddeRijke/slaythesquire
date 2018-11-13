using System;
using System.Collections.Generic;

public static class Extensions
{
    public static Random rng = new Random();
    
    public static Card[] Shuffle(this Card[] list)
    {
        int n = list.Length;  
        while (n > 1) {  
            n--;  
            int k = rng.Next(n + 1);  
            var value = list[k];  
            list[k] = list[n];  
            list[n] = value;  
        }
        return list;
    }

    public static Queue<Card> ToQueue(this Card[] list)
    {
        var queue = new Queue<Card>();
        foreach (var card in list)
        {
            queue.Enqueue(card);
        }
        return queue;
    }
}