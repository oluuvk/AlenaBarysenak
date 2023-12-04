using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonSimply : Cannon
{
    public override void Shoot()
    {
        StartCoroutine(DoubleShootTick());
    }
    public void DoubleShoot()
    {
        if (Ammo == 0)
            return;
        Ball BallCreated = Instantiate(_ball, _spawnPoint.position, Quaternion.identity).GetComponent<Ball>();
        BallCreated.Fly(_spawnPoint.transform.forward, 50);
        Ammo--;
    }
    private IEnumerator DoubleShootTick()
    {
        DoubleShoot();
        yield return new WaitForSeconds(0.3f);
        DoubleShoot();
        StartCoroutine(Delay());
    }
}
