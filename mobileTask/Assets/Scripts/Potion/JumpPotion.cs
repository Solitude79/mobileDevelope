using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPotion : ParentPotion
{

 
    public PlayerControl player;

    public override void EffectPotion()
    {
        player.JumpValue++;
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            EffectPotion();
        }
    }
}
