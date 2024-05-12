using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameState : MonoBehaviour
{
    public static GameState Instance;

    public TextMeshProUGUI totalScoreText;
    public TextMeshProUGUI currentScoreText;

    public int totalScore;
    public int currentScore;

    public bool isOriginal = false;
    
    public void Start()
    {
        totalScore = 0;
        currentScore = 0;
    }

    public void Update()
    {
        switch (SceneManager.GetActiveScene().name)
        {
            case "Menu":
                totalScoreText.text = "" + totalScore;
                
                break;
            case "Game":
                currentScoreText.text = "" + currentScore;
                
                break;
        }
    }

    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}