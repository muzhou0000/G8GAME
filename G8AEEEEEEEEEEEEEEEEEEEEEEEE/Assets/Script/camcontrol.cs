using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camcontrol : MonoBehaviour
{
    public Transform cam, chicken;

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = Vector3.Lerp(cam.position, chicken.position,0.5f * Time.deltaTime);
        cam.position = pos;
    }
}
