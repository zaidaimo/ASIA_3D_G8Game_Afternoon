using UnityEngine;

public class learn : MonoBehaviour
{
    private void Drive(int speed)
    {
        print("開車,時速:" + speed);
    }

    private void Shoot(int count, float speed, string prop = "無", string direction = "前方")
    {
        print("弓箭數量" + count);
        print("弓箭速度" + speed);
        print("弓箭屬性" + prop);
        print("弓箭方向" + direction);

    }

    private int Square(int number)
    {
        return number * number;
    }

    private void Start()
    {
        print("Hello World");
        Drive(200);
        Drive(300);

        Shoot(1, 1.5f);
        Shoot(10, 10.5f, direction: "前後方");
        Shoot(10, 10.5f, prop: "火屬性", direction: "前後方");

        
    }

    
}
