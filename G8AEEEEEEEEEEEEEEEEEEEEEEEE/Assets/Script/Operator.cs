using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operator : MonoBehaviour
{
    public int A = 1, B = 2,C=0;
    public float HP=50;
    public int EXP;
    public float debuff=-0.25f;
    public bool emeny;
    public int qqq;

    void Start()
    {
        print(A++);
        print(++B);
        C =B += 1;
        print(C);
    }
    private void Update()
    {

        print("死亡：" + (HP <= 0));
        print("升級：" + (EXP > 10));
        if (emeny) { 
        HP += debuff;
        }

        if ( qqq >= 150)
        {
            print("攻擊10倍");
        }
        else if (qqq >= 50)
        {
            print("攻擊5倍"); 
        }
        else if (qqq>=20)
        {
            print("攻擊2倍");
        }
    }

}
