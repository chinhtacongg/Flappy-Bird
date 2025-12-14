
using UnityEngine;

public class SoundManager : MonoBehaviour
{
  
    public static SoundManager instance { get; private set; }
    public AudioSource soundSource;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PlaySound(AudioClip clip)
    {
        soundSource.PlayOneShot(clip);
    }
}
