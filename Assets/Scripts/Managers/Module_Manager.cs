using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
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
    public List<Character_Manager> Characters = new List<Character_Manager>();

    private void Start()
    {
        Populate_CharActionIndex();
        if (Characters[0].Death == null)
            Characters[0].Death = new CharacterEvent();
        Characters[0].Death.AddListener(death);
        if (Characters[1].Death == null)
            Characters[1].Death = new CharacterEvent();
        Characters[1].Death.AddListener(death);
    }
    void death(Character_Manager character)
    {
        SceneManager.LoadScene(0);
    }
    [ContextMenu("Pupulate char actions")]
    public void Populate_CharActionIndex()
    {
        CharActionIndex = new Dictionary<Character_Manager, Module_Action[]>();
        foreach (Character_Manager Character in Characters)
        {
            CharActionIndex.Add(Character, FindAllModulesInHierarchy(Character));
        }

        UI_Manager._instance.addCharModules();
    }

    public Module_Action[] FindAllModulesInHierarchy(Character_Manager character)
    {
        Module [] modules = character.GetComponentsInChildren<Module>();
        List<Module_Action> actions = new List<Module_Action>();
        for (int i = 0; i < modules.Length; i++)
        {
            actions.Add(modules[i].action);
        }
        return actions.ToArray();
    }
}
