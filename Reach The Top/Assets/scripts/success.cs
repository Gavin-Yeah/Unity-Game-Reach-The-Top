using UnityEngine;
using System.Collections;

public class success : MonoBehaviour {
    // Use this for initialization

    public bool WindowShow = false;
    void OnGUI()
    {
        if (WindowShow)
            GUI.Window(0, new Rect(30, 30, 200, 100), MyWindow, "Information");
    }
    //dialogue function;
    void MyWindow(int WindowID)
    {
        GUILayout.Label("WIN！！！");
    }
    //collision event;
    void OnCollisionEnter2D(Collision2D coll)
    {
        Debug.Log("show");
        if (WindowShow)
            WindowShow = false;
        else
            WindowShow = true;
    }

    //reference http://zhidao.baidu.com/link?url=KNa0bIo18zvt9O28GbnmgRBrjQog26SHWN2FE3vpiB96rcgftXYB1sDHq18hpoAl6-BZRuKmx6oRU1TOeV7yl8Z76RjuQnmukhYsq42cMQK





}

