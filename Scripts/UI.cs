using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
     [SerializeField] private GameManager gameManager;
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private TMP_Text healthText;
    [SerializeField] private Slider healthBar;

    private void Start()
    {
        gameManager.OnHealthChanged += UpdateHealth;
        gameManager.OnScoreChanged += UpdateScore;
    }

    public void UpdateScore(int score)
    {
        scoreText.text = $"Score: {score}";
    }

    public void UpdateHealth(int health)
    {
        healthText.text = $"Health: {health}";
        healthBar.value = health;
    }
}
