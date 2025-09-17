
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private GameObject gameOverPanel;

    private void Awake()
    {
        gameOverPanel.SetActive(false);
    }
    private void Update()
    {
        SetScoreText();
        GameOverPanel();
    }

    private void GameOverPanel()
    {
        if(GameManager.instance.GetDedValue() == true)
        {
            gameOverPanel.SetActive(true);
        }
    }

    public void Replay()
    {
        SceneManager.LoadScene(1);
    }
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }

    public void SetScoreText()
    {
        scoreText.SetText(GameManager.instance.GetScore().ToString());
    }


}
