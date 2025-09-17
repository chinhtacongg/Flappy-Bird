
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject[] pipes;
    [SerializeField] private float timeToSpawn;

    private bool isDED ;
    private int score;
  

    public static GameManager instance { get; private set; }

    private float timerCounter;

    private void Awake()
    {
        if (instance == null) 
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
       
        timerCounter = 0;
        
    }
  

    // Update is called once per frame
    void Update()
    {
        if (isDED) return;
        timerCounter -= Time.deltaTime;
        if (timerCounter < 0)
        {
            SpawnPos();
            timerCounter = timeToSpawn;
        }
            


    }

    private void SpawnPos()
    {
        int index = FindPipe();

        GameObject obj = pipes[index];
        obj.GetComponent<PipeMoveMent>().SetActive();
        obj.transform.position = new Vector2(12.5f, Random.Range(-5.2f, -0.6f));

       
    }


    private int FindPipe()
    {
        for (int i = 0; i < pipes.Length; i++)
        {
            if (!pipes[i].activeInHierarchy)
            {
                return i;
            }
        }
        return 0;
    }

    public void SetDedValue(bool ded)
    {
        isDED = ded;
    }

    public bool GetDedValue()
    {
        return isDED;
    }
    public void SetScore(int point)
    {
        score += point;
    }

    public int GetScore()
    {
        return score;
    }



}
