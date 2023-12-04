using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSize : Target
{
    public override void OnCollisionEnter(Collision collision)
    {
        transform.localScale = new Vector3(4, 4, 0.5f);
    }
}
