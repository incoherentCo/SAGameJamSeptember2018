using UnityEngine;
using EasyButtons;
using System.Collections;

public class UI_Manager : MonoBehaviour
{
    #region  Singleton management
    public static UI_Manager _instance;
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
    [SerializeField] RectTransform P1_ModuleContainer, P2_ModuleContainer;
    [SerializeField] RectTransform Action;

    public void addCharModules()
    {
        Character_Manager[] chars = Module_Manager._instance.Characters.ToArray();

        Module_Action[] actionP1 = Module_Manager._instance.CharActionIndex[chars[0]];
        foreach (var action in actionP1)
            AddModule(P1_ModuleContainer, action);
        if (chars[1] != null)
        {
            Module_Action[] actionP2 = Module_Manager._instance.CharActionIndex[chars[1]];
            foreach (var action in actionP2)
                AddModule(P2_ModuleContainer, action);
        }



    }
    public void AddModule(RectTransform container, Module_Action action)
    {
        RectTransform AddedAction = Instantiate(Action, container);
        AddedAction.GetComponent<UI_ModuleAction>().SetModuleData(action.Icon,action.Name,action.Action);
    }
    
    [ContextMenu("add Dummy Module to P1"),Button]
    public void AddDummyModuleToP1()
    {
        RectTransform AddedAction = Instantiate(Action, P1_ModuleContainer);
        AddedAction.GetComponent<UI_ModuleAction>().SetDummyData();
    }

    [ContextMenu("add Dummy Module to P2"),Button]
    public void AddDummyModuleToP2()
    {
        RectTransform AddedAction = Instantiate(Action, P2_ModuleContainer);
        AddedAction.GetComponent<UI_ModuleAction>().SetDummyData();
    }
}
