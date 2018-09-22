using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public abstract class Module_Action : ScriptableObject {

    public string Name;
    public Sprite Icon;
    public string AnimationNodeName;
    public AnimationCurve ButtonGrowthScale;

    public virtual void Action()
    {
        Debug.Log(Name+" triggered");
    }
    IEnumerator ScaleByCurve(UnityAction<float> scale)
    {
        for (float i = 0; i < ButtonGrowthScale.length; i++)
        {
            scale(ButtonGrowthScale.Evaluate(i));
            yield return null;
        }
    }
}
