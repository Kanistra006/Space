using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))  // Проверяем, была ли нажата любая клавиша
        {
            SceneManager.LoadScene("MainScene");  // Загружаем игровую сцену
        }
    }
}