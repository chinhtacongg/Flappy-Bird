
using UnityEngine;

public class Pipe : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null && collision.CompareTag("SceneLimit"))
        {
            transform.parent.gameObject.SetActive(false);
        }
    }
}
