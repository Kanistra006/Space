using System.Collections;
using UnityEngine;

public class PlayerUltimate : MonoBehaviour
{
    Animator animator;
    PlayerShooting playerShooting;
    float ultimateDuration = 5f;

    void Start()
    {
        animator = GetComponent<Animator>();
        playerShooting = GetComponent<PlayerShooting>();
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
        Debug.Log("Ultimate started");
        animator.SetBool("isUltimateActiveNow", true);

        float remainingDuration = ultimateDuration;
        while (remainingDuration > 0)
        {
            playerShooting.Ultimate();
            remainingDuration -= Time.deltaTime;
            yield return null; // Приостанавливает выполнение до следующего кадра
        }

        playerShooting.UltimateOver();
        animator.SetBool("isUltimateActiveNow", false);
        Debug.Log("Ultimate finished");
    }
}
