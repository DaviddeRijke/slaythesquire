using System;
using UnityEngine;
using UnityEngine.Events;

namespace Utils
{
	public class CardEvent : UnityEvent<Card>
	{
	}

	public class CardViewEvent : UnityEvent<CardView3D>
    {
    }

    public class IntEvent : UnityEvent<int>
    {
    }
}