
using UnityEngine;

public class Learn : MonoBehaviour
{

    private void Drive(int speed)
    {
        print("車子噗噗起洽起洽"+speed);
    }

    private void Love (int times,string name="Tony",string zzcoco="123")
    {
        print("對著" + name + "說");
        print("I LOVE YOU " + times);
        print("zzcoco" + zzcoco);
    }

    private void Start()
    {
        print("HELL-o");

        Drive(200);
        Drive(400);

        Love(1000);
        Love(1400,"456");
        Love(1800,zzcoco:"456");
        Love(2000,"marry");
        Love(3000);
        


    }
}
