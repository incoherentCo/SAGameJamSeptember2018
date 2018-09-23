using UnityEngine;
using System.Collections;

public class Module : MonoBehaviour
{
    public Module_Action action;

    private void Start()
    {
        if (action.GetType() == typeof(BasicAnimBased))
        {
            (action as BasicAnimBased).anim = GetComponentInParent<Animator>();
        }
        InitModule();
    }
    [ContextMenu("Init Module")]
    public void InitModule()
    {
        if (action.Sprite != null && GetComponent<SpriteRenderer>() != null)
        GetComponent<SpriteRenderer>().sprite = action.Sprite;
    }
}
