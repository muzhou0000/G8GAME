using UnityEngine;

public class Chicken : MonoBehaviour
{

    Rigidbody ridi;
    [Header("移動速度"), Range(1, 100), Tooltip("G8雞的")]
    public int speed;

    #region 行動
    void run(int speed)
    {
        print("G8雞的跑步速度："+speed);
    }
    void turn(float turning)
    {
        print("G8雞的旋轉：" + turning);

    }
    void yell(string yell="GGGGGGGGGGGGGGGGGGGGGGGGGG")
    {
        print("G8雞的叫聲：" + yell);

    }
    void take(string say="幹")
    {
        print("G8雞說：" + say);

    }
    void viewmission(string see="正在檢視")
    {
        print("G8雞" + see);

    }

    void G8chicken_motion(int speed, float turning, string yell = "88888888888888888888", string say = "幹!", string see = "正在檢視...")
    {
        print("G8雞的跑步速度：" + speed);
        print("G8雞的旋轉：" + turning);
        print("G8雞的叫聲：" + yell);
        print("G8雞說：" + say);
        print("G8雞" + see);

    }
    #endregion
    private void Start()
    {
        ridi = GetComponent<Rigidbody>();
        G8chicken_motion(10, 8);

    }

    public static void Updata()
    {




    }

}
