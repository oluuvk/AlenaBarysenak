using System.Collections;
using UnityEngine;

public class GunSphere : Gun
{
    public override void Shoot()
    {
        StartCoroutine(ShootTick());
    }
    public void TribleShoot()
    {
        Charge ChargeForce = Instantiate(_charge, _spawnPoint.position, Quaternion.identity).GetComponent<Charge>();
        _charge.Fly(_spawnPoint.transform.forward, 50);
    }
    private IEnumerator ShootTick()
    {
        TribleShoot();
        yield return new WaitForSeconds(0.5f);
        TribleShoot();
        yield return new WaitForSeconds(0.5f);
        TribleShoot();
    }
}
