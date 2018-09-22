using UnityEngine;
using EasyButtons;
using System.Collections;

public class UI_Manager : MonoBehaviour
{
    [SerializeField] RectTransform P1_ModuleContainer, P2_ModuleContainer;
    [SerializeField] RectTransform Action;

    public void AddModule(RectTransform container)
    {
        RectTransform AddedAction = Instantiate(Action, container);
        AddedAction.GetComponent<UI_ModuleAction>().SetDummyData();
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
