using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotion : ParentPotion
{
   
    public PlayerControl player;

    public override void EffectPotion()
    {
        player.HealthPoints += 5;
        DestroyPotion();
    }
    public override void DestroyPotion()
    {
        base.DestroyPotion();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            EffectPotion();
        }
    }
}
