using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using Resolve;
using UnityEngine;
using Utils;
using Wilberforce.FinalVignette;
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

    public static EffectData ToData(this Effect effect, Knight caster)
    {
        var ed = new EffectData {Effect = effect, Caster = caster};
        return ed;
    }

    public static Queue<EffectData> ToSortedQueue(this List<Effect> own, List<Effect> other, Knight p1, Knight p2)
    {
        var queue = new Queue<EffectData>();
        for (int i = 0; i < Mathf.Max(own.Count, other.Count); ++i)
        {
            if (own.Count > i && own[i] is INoInteraction)
            {
                queue.Enqueue(own[i].ToData(p1));
            }
            if (other.Count > i && other[i] is INoInteraction)
            {
                queue.Enqueue(other[i].ToData(p2));
            }
        }
        
        //block
        bool ownBlocks = false;
        bool otherBlocks = false;
        for (int i = 0; i < Mathf.Max(own.Count, other.Count); ++i)
        {
            if (own.Count > i && own[i] is IBlock)
            {
                ownBlocks = true;
                queue.Enqueue(own[i].ToData(p1));
                var a = GetAttack(other);
                if (a != null) queue.Enqueue(a.ToData(p2));
            }
            if (other.Count > i && other[i] is IBlock)
            {
                otherBlocks = true;
                queue.Enqueue(other[i].ToData(p2));
                var a = GetAttack(own);
                if (a != null) queue.Enqueue(a.ToData(p1));
            }
        }

        if (!otherBlocks && GetAttack(own) != null)
        {
            queue.Enqueue(GetAttack(own).ToData(p1));
        }
        if (!ownBlocks && GetAttack(other) != null)
        {
            queue.Enqueue(GetAttack(other).ToData(p2));
        }        
        return queue;
    }

    private static Effect GetAttack(List<Effect> effects)
    {
        foreach (var at in effects)
        {
            if (at is IBlockable) return at;
        }
        return null;
    }

}