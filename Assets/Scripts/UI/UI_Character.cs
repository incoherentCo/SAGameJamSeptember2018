using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UI_Character : MonoBehaviour {

    public Character_Manager character;
    Slider healthBar;

    private void Start()
    {
        healthBar = GetComponent<Slider>();
    }

    private void Update()
    {
        healthBar.value = character.LifeTotal;
    }
}
