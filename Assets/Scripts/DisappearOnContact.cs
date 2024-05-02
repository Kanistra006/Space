using UnityEngine;

public class DisappearOnContact : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Triggered with " + other.name);
        // ���������, ������������� �� ������, � ������� ��������� ������������, ������������� �������
        if (other.gameObject.tag == "Player") // ���������, ��� � ������� ������ ���� ��� "Player"
        {
            Destroy(gameObject); // ���������� ���� ������
        }
    }
}

