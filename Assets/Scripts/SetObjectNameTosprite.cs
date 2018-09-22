using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetObjectNameTosprite : MonoBehaviour {

    public string PostFix = "_Left";
    [ContextMenu("SetName")]
    public void SetName()
    {
        gameObject.name = GetComponent<SpriteRenderer>().sprite.name+PostFix;
    }
}
