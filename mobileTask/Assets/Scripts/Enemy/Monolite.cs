using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monolite : Entity
{
    //private float _damage = 1f;
    
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            collision.gameObject.GetComponent<PlayerControl>().GetDamage(0.1f);
        }
    }
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.CompareTag("Player"))
        {

            hit.gameObject.GetComponent<PlayerControl>().GetDamage(0.1f);
        }
    }
    
    public override void GetDamage(float damage)
    {
        
    }
    public override void Die()
    {
        base.Die();
    }
}
