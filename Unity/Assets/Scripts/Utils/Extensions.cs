using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using DefaultNamespace.Resolve;
using Resolve;
using UnityEngine;
using Random = System.Random;

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

    public static Queue<Effect> ToSortedQueue(this List<Effect> own, List<Effect> other)
    {
        var queue = new Queue<Effect>();
        var no1 = own.SortOnInteraction();
        var no2 = other.SortOnInteraction();
        for (int i = 0; i < Mathf.Max(no1.Count, no2.Count); i++)
        {
            if (i < no1.Count)
            {
                queue.Enqueue(no1[i]);
                own.Remove(no1[i]);
            }
            if (i < no2.Count)
            {
                queue.Enqueue(no2[i]);
                own.Remove(no2[i]);
            }
        }

        var bo1= own.SortOnBlockable();
        var bo2= other.SortOnBlockable();
        var block1 = own.GetBlock();
        var block2 = other.GetBlock();
        for (int i = 0; i < Mathf.Max(bo1.Count, bo2.Count); i++)
        {
            if (i < bo1.Count)
            {
                queue.Enqueue(bo1[i]);
                own.Remove(bo1[i]);
                if(block2 != null) queue.Enqueue(block2);
            }

            if (i < bo2.Count)
            {
                queue.Enqueue(bo2[i]);
                own.Remove(bo2[i]);
                if(block1 != null) queue.Enqueue(block1);
            }
        }    
        return queue;
    }

    private static Effect GetBlock(this List<Effect> list)
    {
        return list.Find(e => e is IBlock);
    }

    private static List<Effect> SortOnBlockable(this List<Effect> list)
    {
        return list.FindAll(e => e is IBlockable);
    }

    private static List<Effect> SortOnInteraction(this List<Effect> list)
    {       
        return list.FindAll(e => e is INoInteraction);
    }
}