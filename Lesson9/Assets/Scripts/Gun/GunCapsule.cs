using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunCapsule : Gun
{
    [SerializeField] private Transform _spawnPoint1;
    public override void Shoot()
    {
        StartCoroutine(ShootTick());
    }
    public void DoubleShoot()
    {
        Charge ChargeForce = Instantiate(_charge, _spawnPoint.position, Quaternion.identity).GetComponent<Charge>();
        ChargeForce.Fly(_spawnPoint.transform.forward, 65);
        Charge ChargeForce1 = Instantiate(_charge, _spawnPoint1.position, Quaternion.identity).GetComponent<Charge>();
        ChargeForce1.Fly(_spawnPoint1.transform.forward, 65);
    }
    private IEnumerator ShootTick()
    {
        DoubleShoot();
        yield return new WaitForSeconds(0.5f);
    }
}
