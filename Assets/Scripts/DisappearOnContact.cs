using UnityEngine;

public class DisappearOnContact : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Triggered with " + other.name);
        // Проверяем, соответствует ли объект, с которым произошло столкновение, определенному условию
        if (other.gameObject.tag == "Player") // Убедитесь, что у объекта игрока есть тег "Player"
        {
            Destroy(gameObject); // Уничтожает этот объект
        }
    }
}

