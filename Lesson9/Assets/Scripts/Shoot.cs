using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] private Gun _gun;

    [SerializeField] private Gun _gun1;
    [SerializeField] private Gun _gun2;
    [SerializeField] private Gun _gun3;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _gun.Shoot();
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            _gun1.gameObject.SetActive(true);
            _gun2.gameObject.SetActive(false);
            _gun3.gameObject.SetActive(false);
            _gun = _gun1;
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            _gun1.gameObject.SetActive(false);
            _gun2.gameObject.SetActive(true);
            _gun3.gameObject.SetActive(false);
            _gun = _gun2;
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            _gun1.gameObject.SetActive(false);
            _gun2.gameObject.SetActive(false);
            _gun3.gameObject.SetActive(true);
            _gun = _gun3;
        }
    }
}
