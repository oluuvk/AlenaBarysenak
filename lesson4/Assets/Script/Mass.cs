using UnityEngine;
public class Mass : MonoBehaviour
{
    public float Amount;
    private void Update()
    {
        transform.localScale = new Vector3(Amount, Amount, Amount);
    }
}