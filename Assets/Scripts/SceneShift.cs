using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneShift : MonoBehaviour {

    public void LoadScene(int scene)
    {
        SceneManager.LoadScene(scene);
    }
}
