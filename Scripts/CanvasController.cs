using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasController : MonoBehaviour
{
    List<ButtonsLenguage> buttons = new List<ButtonsLenguage>();
    string[] lenguageList = {"Spanish", "English", "French"};
    public Text lenguage;
    private int len;

    private void Start()
    {
        lenguage.text = lenguageList[0];
        len=0;
    }

    public void SetEnableDisable(GameObject obj){
        if(obj.activeSelf){
            obj.SetActive(false);
        }else{
            obj.SetActive(true);
        }
    }

    public void ChangeLenguage(){
        len++;
        if(len>=lenguageList.Length){
            len=0;
        }
        lenguage.text = lenguageList[len];
        ChangeEveryButtons(len);
    }

    public void ChangeEveryButtons(){
        
    }

}
