
using Unity.VisualScripting;
using UnityEngine;

public class ScoreZone : MonoBehaviour
{
    private bool hasScore = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if( collision != null && collision.CompareTag("Player") && !hasScore)
        {
            GameManager.instance.SetScore(1);
            hasScore = true;
        }
    }

    private void OnEnable()
    {
        hasScore = false; // reset moi lan duoc reuse nho pooling
    }
}
