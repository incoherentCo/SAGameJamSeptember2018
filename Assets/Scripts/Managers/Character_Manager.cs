using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class Character_Manager   : MonoBehaviour {

	public int LifeTotal;
    public CharacterEvent Death;

    public void DecreaseLife(int ToDecrease)
    {
        LifeTotal -= ToDecrease;
        if (LifeTotal < 0)
        {
            Death.Invoke(this); 
        }
    }
}
public class CharacterEvent : UnityEvent<Character_Manager> { }