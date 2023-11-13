using System.Collections;
using TMPro;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private Ball _ball;
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private bool _isSpawning;
    private int _spawnCount = 5;
    [SerializeField] private TextMeshProUGUI _attempts;
    [SerializeField] private bool _spendAttempts;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _isSpawning)
        {
            StartCoroutine(ShootTick());
        }
        else if ((Input.GetKeyDown(KeyCode.R)) && _spawnCount <= 0)
        {
            StartCoroutine(AddAttempts());
        }
    }
    private void CreateBall()
    {
        Ball BallCreated = Instantiate(_ball, _spawnPoint.position, Quaternion.identity).GetComponent<Ball>();
        BallCreated.Fly(_spawnPoint.transform.forward, 50);
        StartCoroutine(Delay());
    }
    private IEnumerator ShootTick()
    {
        _isSpawning = false;
        _attempts.text = "Осталось " +_spawnCount.ToString() + " попыток";
        yield return new WaitForSeconds(0.2f);
        CreateBall();
    }
    private IEnumerator Delay()
    {
        yield return new WaitForSeconds(0.5f);
        _isSpawning = true;
        if (_spawnCount > 0 && _spendAttempts)
        {
            for (int i=0;  i < _spawnCount; i++)
            {
                _spawnCount--;
            }
        }
        else if (_spawnCount == 0)
        {
            _spendAttempts = false; 
            _isSpawning = false;
        }
    }
    private IEnumerator AddAttempts()
    {
        yield return new WaitForSeconds(3);
        _spendAttempts = true;
        _isSpawning = true;
        _spawnCount = 5;
    }
}
