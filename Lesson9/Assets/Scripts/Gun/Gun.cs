using System.Collections;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] protected private Charge _charge;
    [SerializeField] protected private Transform _spawnPoint;
    [SerializeField] private float _delay;
    public virtual void Shoot()
    {
        Charge ChargeForce = Instantiate(_charge, _spawnPoint.position, Quaternion.identity).GetComponent<Charge>();
        ChargeForce.Fly(_spawnPoint.transform.forward, 40);
        StartCoroutine(Delay());
    }
    protected private IEnumerator Delay()
    {
        yield return new WaitForSeconds(_delay);
    }
}
