using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public abstract class ModuleAction : ScriptableObject {

    public string Name;
    public Sprite Icon;
    public string AnimationNodeName;
    public AnimationCurve ButtonGrowthScale;
    public Button btn;

    public virtual void Action()
    {
        Debug.Log(Name+" triggered");
    }
    public void MakeButton(ref Button btn)
    {
        btn.transform.GetComponentInChildren<Text>().text = name;
        btn.GetComponent<Image>().sprite = Icon;
        btn.onClick.AddListener(Action);
        float scale = 0;
        btn.StartCoroutine(ScaleByCurve((x) => scale = x));
        btn.transform.localScale = new Vector3(scale,scale,scale);
    }
    IEnumerator ScaleByCurve(UnityAction<float> scale)
    {
        for (float i = 0; i < ButtonGrowthScale.length; i++)
        {
            scale(ButtonGrowthScale.Evaluate(i));
            yield return null;
        }
    }
    public void init()
    {
        MakeButton(ref btn);
    }
}
