
using UnityEngine;

public class Learn : MonoBehaviour
{
    private int Square(int number = 2)
    {
        return (number * number);
    }

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

        print(Square());

        int result = Square(4);
        print(result);

        print(Random.Range(1, 10));

        Debug.Log("456");
        Debug.LogWarning("456");
        Debug.LogError("456");

    }

    private void Update()
    {
        //print(Input.mousePosition);

        print(Input.GetKeyDown(KeyCode.Space));
        
    }
}
