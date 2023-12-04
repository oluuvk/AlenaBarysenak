using System.Collections;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private Cannon _cannon;

    [SerializeField] private Cannon _cannon1;
    [SerializeField] private Cannon _cannon2;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _cannon.CanShoot && _cannon.Ammo>0)
        {
            _cannon.Shoot();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            _cannon.Reload();
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            _cannon1.gameObject.SetActive(true);
            _cannon2.gameObject.SetActive(false);
            _cannon = _cannon1;
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            _cannon1.gameObject.SetActive(false);
            _cannon2.gameObject.SetActive(true);
            _cannon = _cannon2;
        }
    }
}
