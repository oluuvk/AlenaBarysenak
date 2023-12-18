using TMPro;
using UnityEngine;

public class Target : MonoBehaviour
{
    private int _count;
    private CounterUI _counter;
    public void SetCounter(CounterUI counter)
    {
        _counter = counter;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Ball>())
        {
            _counter.AddCount();
            Destroy(collision.gameObject);
        }
    }
}
    
        
