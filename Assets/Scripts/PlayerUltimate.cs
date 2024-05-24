using System.Collections;
using UnityEngine;

public class PlayerUltimate : MonoBehaviour
{
    Animator animator;
    PlayerShooting playerShooting;
    PlayerHealth playerHealth;
    float ultimateDuration = 5f;

    void Start()
    {
        animator = GetComponent<Animator>();
        playerShooting = GetComponent<PlayerShooting>();
        playerHealth = GetComponent<PlayerHealth>();
    }

    void Update()
    {
        if (GameManager.score % 5 == 0 && GameManager.score != 0 && !animator.GetBool("isUltimateActiveNow"))
        {
            Debug.Log("Ultimate is ready");
            StartCoroutine(Ultimate());
        }
    }

    IEnumerator Ultimate()
    {
        
        animator.SetBool("isUltimateActiveNow", true);

        float remainingDuration = ultimateDuration;
        while (remainingDuration > 0)
        {
            playerShooting.Ultimate();
            playerHealth.Ultimate();
            remainingDuration -= Time.deltaTime;
            yield return null; // Приостанавливает выполнение до следующего кадра
        }

        playerShooting.UltimateOver();
        playerHealth.UltimateOver();
        animator.SetBool("isUltimateActiveNow", false);
        
    }
}
