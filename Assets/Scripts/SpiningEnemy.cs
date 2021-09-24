using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiningEnemy : MonoBehaviour
{
    public float rotSpeed = 5f;
    void Update()
    {
        Spin();
    }

    void Spin()
    {
        transform.Rotate(0, rotSpeed * Time.deltaTime, 0);
    }
}
