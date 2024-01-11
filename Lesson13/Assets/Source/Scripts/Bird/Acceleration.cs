using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acceleration : MonoBehaviour
{
    private void Key(Bird bird)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            bird.GetAcceleration();
        }
    }
}
