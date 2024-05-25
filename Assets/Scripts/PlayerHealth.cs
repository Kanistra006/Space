using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{

    public int maxHealth = 5; // Максимальное здоровье врага
    public int currentHealth; // Текущее здоровье врага
    private Coroutine damageCoroutine;

    void Start()
    {
        currentHealth = maxHealth; // Начальное здоровье при создании врага
    }
    void OnTriggerEnter2D(Collider2D other)
    {

        // Проверяем, соответствует ли объект, с которым произошло столкновение, определенному условию
        if (other.gameObject.tag == "Enemy" || other.gameObject.tag == "EnemyBullet") // Убедитесь, что у объекта игрока есть тег "Player"
        {
            TakeDamage(1);

        }
        else if (other.gameObject.tag == "BossLaser")
        {
            if (damageCoroutine == null) // Проверяем, запущена ли уже корутина
            {
                damageCoroutine = StartCoroutine(DamageOverTime(1, other));
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "BossLaser")
        {
            if (damageCoroutine != null) // Проверяем, запущена ли корутина
            {
                StopCoroutine(damageCoroutine);
                damageCoroutine = null; // Сбрасываем ссылку на корутину
            }
        }
    }


    IEnumerator DamageOverTime(int damage, Collider2D other)
    {
        while (true)
        {
            TakeDamage(damage);
            yield return new WaitForSeconds(1f);
        }
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage; // Уменьшаем здоровье на величину полученного урона
        if (currentHealth <= 0)
        {
            Die(); // Функция смерти, если здоровье опустится до 0 или ниже
        }
    }



    public void Heal(int healPower)
    {
        currentHealth = Mathf.Min(maxHealth, currentHealth + healPower);
    }

    private void Die()
    {
        Destroy(gameObject); // Уничтожаем объект врага
        SceneManager.LoadScene("StartScene");
        // Здесь можно добавить логику для анимации смерти, очков и т.д.
    }
}
