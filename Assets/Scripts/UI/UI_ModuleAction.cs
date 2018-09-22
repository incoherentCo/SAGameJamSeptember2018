using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class UI_ModuleAction : MonoBehaviour {

    [SerializeField] private Image _icon;
    [SerializeField] private Text _text;
    [SerializeField] private Button _button;


    public void InitModule(Sprite icon,string name,UnityAction Action)
    {
        _icon.sprite = icon;
        _text.text = name;
        _button.onClick.RemoveAllListeners();
        _button.onClick.AddListener(Action);
    }

    [ContextMenu("Set Dummy Data")]
    public void SetDummyData()
    {
        _icon.color = Color.red;
        _text.text = "Dummy Data";
    }
}
