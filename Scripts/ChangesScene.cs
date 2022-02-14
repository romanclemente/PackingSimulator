using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangesScene : MonoBehaviour
{
    public void ChangeSceneUser(string scene){
        SceneManager.LoadScene(scene);
    }
}
