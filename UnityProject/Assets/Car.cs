using UnityEngine;

public class Car : MonoBehaviour
{
    [Header("速度"), Range(1, 150)]
    public float speedMove = 10;
    [Header("速度"), Range(1, 100)]
    public float speedTurn = 30;
    [Header("汽車檔次"), Range(1, 4)]
    public int carShift = 1;
    [Header("汽車品牌")]
    public string brand = "BMW";
    [Header("是否煞車")]
    public bool brakes;
    [Header("汽車顏色")]
    public Color color = Color.gray;
    [Header("汽車變形元件")]
    public Transform car;

    public void Move(int direction)
    {
        car.Translate(0, 0, speedMove * Time.deltaTime * direction);
    }

    public void Turn(int direction)
    {
        car.Rotate(0, speedTurn * Time.deltaTime * direction, 0);
    }
}
