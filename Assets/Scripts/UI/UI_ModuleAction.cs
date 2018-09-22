using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class UI_ModuleAction : MonoBehaviour {
    private Image _icon;
    private Text _text;
    private Button _button;

    public void InitModule(Sprite icon,string name,UnityAction Action)
    {
        _icon.sprite = icon;
        _text.text = name;
        _button.onClick.RemoveAllListeners();
        _button.onClick.AddListener(Action);
    }
}
