
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float force;
    [SerializeField] private AudioClip playerWingSound;
    [SerializeField] private AudioClip playerDeadSound;
    

    private bool isOut;
    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.GetDedValue()) return;
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = new Vector2(rb.velocity.x, force );
            SoundManager.instance.PlaySound(playerWingSound);

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    { 
        if( collision != null && collision.CompareTag("Pipe") )
        {
            GameManager.instance.SetDedValue(true);
            rb.velocity = Vector2.zero;
            rb.bodyType = RigidbodyType2D.Kinematic;
            SoundManager.instance.PlaySound(playerDeadSound);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision != null && collision.gameObject.CompareTag("Ground"))
        {
            GameManager.instance.SetDedValue(true);
            rb.velocity = Vector2.zero;
            rb.bodyType = RigidbodyType2D.Kinematic;
        }
    }

}
