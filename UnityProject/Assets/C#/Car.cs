using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{

    #region 設定變數
    [Header("是否煞車")]//讓面板上看到文字
    public bool stop = false;//設定是否煞車
    [Header("移動速度"), Range(0.0f, 20.0f)]//Range:數值變成BAR條
    public float speed = 10.0f;//移動速度
    [Header("旋轉速度"), Range(0.0f, 20.0f)]//Range:數值變成BAR條
    public float turn = 10.0f;//旋轉速度
    [Header("車名"), Tooltip("用來設定車種")]//Tooltip:當滑鼠移動到文字時會顯示註解
    public string carName = "BMW";//設定角色名
    public Transform myCar;//設定角色及攝影機的座標

    #endregion
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// Car移動方法
    /// </summary>
    public void CarGo()
    {
        myCar.Translate(0.0f, 0.0f, speed * Time.deltaTime);//Car前進
    }
    public void CarDown()
    {
        myCar.Translate(0.0f, 0.0f, -1.0f * speed * Time.deltaTime);//Car後退
    }
    public void CarLeft()
    {
        myCar.Rotate(0.0f, -1.0f * turn * Time.deltaTime, 0.0f);//向左旋轉
    }
    public void CarRight()
    {
        myCar.Rotate(0.0f, turn * Time.deltaTime, 0.0f);//向右旋轉
    }
    public void CarStop()
    {
        myCar.Rotate(0.0f, myCar.rotation.y, 0.0f);//旋轉停止
        myCar.Translate(0.0f, 0.0f, myCar.position.z);//前進停止
    }
 
}
