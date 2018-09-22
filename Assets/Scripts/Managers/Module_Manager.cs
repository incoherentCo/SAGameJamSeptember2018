using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Module_Manager : MonoBehaviour {

    IDictionary<Character, ModuleAction[]> CharActionIndex;

    private void Start()
    {
        CharActionIndex = new Dictionary<Character, ModuleAction[]>()
    }


    public ModuleAction[] FindAllModulesInHierarchy(GameObject character)
    {
        return GetComponentsInChildren<ModuleAction>();
    }
}
