using UnityEngine;

public class Enemy : MonoBehaviour, IHitable
{
    [SerializeField] private MeshRenderer _mesh;
    [SerializeField] private Rigidbody _rigidbody;
    public void Move(Vector3 direction)
    {
        _rigidbody.AddForce(direction*1000);   
    }
    private void Awake()
    {
        _mesh = GetComponent<MeshRenderer>();
    }
    public void SetUp(Color color)
    {
        _mesh.material.color = color;
    }

    public void Die()
    {
        Debug.Log("Ви умерли");
    }
    public void Hit()
    {
        Debug.Log("Я получил 5 урона");
    }

}
