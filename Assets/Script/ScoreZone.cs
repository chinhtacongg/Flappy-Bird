
using Unity.VisualScripting;
using UnityEngine;

public class ScoreZone : MonoBehaviour
{
    private bool hasScore = false;
    [SerializeField] private AudioClip scoreSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if( collision != null && collision.CompareTag("Player") && !hasScore)
        {
            SoundManager.instance.PlaySound(scoreSound);
            GameManager.instance.SetScore(1);
            hasScore = true;
        }
    }

    private void OnEnable() // function se duoc goi moi khi obj duoc setActive
    {
        hasScore = false; // reset moi lan duoc reuse nho pooling
    }
}
