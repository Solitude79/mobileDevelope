using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float HealthPoint;

    public float MaxHealthPoint;

    public virtual void TakeHit(float damage)
    {
        HealthPoint -= damage;
        if (HealthPoint <= 0)
        {
            Destroy(gameObject);
        }
        
    }

    public void GetHealth(float bonusHealth)
    {
        
        if ((HealthPoint + bonusHealth) > MaxHealthPoint)
        {
            HealthPoint = MaxHealthPoint;
            Debug.Log($"Максимальное здоровье {HealthPoint}");
        }
        else
        {
            HealthPoint += bonusHealth;
        }
    }
}
