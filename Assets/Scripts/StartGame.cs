using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))  // ���������, ���� �� ������ ����� �������
        {
            SceneManager.LoadScene("MainScene");  // ��������� ������� �����
        }
    }
}