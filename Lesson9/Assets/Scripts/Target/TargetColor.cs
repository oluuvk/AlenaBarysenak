using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetColor : Target
{
    public override void OnCollisionEnter(Collision collision)
    {
        transform.gameObject.GetComponent<MeshRenderer>().material.color = new Color(0.48f, 0.47f, 0, 0);
    }
}
