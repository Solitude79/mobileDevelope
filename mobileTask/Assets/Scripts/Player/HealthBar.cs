using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider Slider;
    public PlayerControl Player;

    private void SetHealth(float health)
    {
        Slider.value = health;
    }
    private void SetMaxHealth(float health)
    {
        Slider.maxValue = health;
        Slider.value = health;
    }

    private void Start()
    {
        SetMaxHealth(Player.HealthPoints);
    }
    private void Update()
    {
        SetHealth(Player.HealthPoints);
    }

    
}
