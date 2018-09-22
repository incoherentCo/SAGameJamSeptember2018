using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Module_Manager : MonoBehaviour {

    #region  Singleton management
    public static Module_Manager _instance;
    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
        }
        else
        {
            Destroy(this);
        }
    }
    private void OnDestroy()
    {
        _instance = null;
    }
    #endregion

    public IDictionary<Character_Manager, Module_Action[]> CharActionIndex;

    private void Start()
    {
        Populate_CharActionIndex();
    }

    public void Populate_CharActionIndex()
    {
        CharActionIndex = new Dictionary<Character_Manager, Module_Action[]>();
        foreach (Character_Manager Character in FindObjectsOfType<Character_Manager>())
        {
            CharActionIndex.Add(Character, FindAllModulesInHierarchy(Character));
        }
    }

    public Module_Action[] FindAllModulesInHierarchy(Character_Manager character)
    {
        return character.GetComponentsInChildren<Module_Action>();
    }
}
