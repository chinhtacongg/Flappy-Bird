using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveMent : MonoBehaviour
{
    [SerializeField] private float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.GetDedValue() == true) return;
        transform.Translate(Vector2.left * speed *  Time.deltaTime);
    }

    public void SetActive()
    {
        gameObject.SetActive(true);
    }

}
