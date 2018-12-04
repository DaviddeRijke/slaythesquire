using System.Collections;
using System.Collections.Generic;
using Resolve;
using UnityEngine;

[CreateAssetMenu(fileName = "EffectBlock", menuName = "Effects/Block")]
public class EffectBlock : Effect, IBlock
{
    public override void Activate(Knight self, Knight opponent)
    {
        self.gameObject.GetComponent<KnightMovement>().PlayDuckAnimation();
    }
}
