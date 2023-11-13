using TMPro;
using UnityEngine;

public class Target : MonoBehaviour
{
   [SerializeField] private TextMeshProUGUI _textMeshPro;
    private int _count;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Ball>())
        {
            _count++;
            _textMeshPro.text = "�� ����� "+ _count.ToString()+" ���";
            Destroy(collision.gameObject);
        }
    }
}
