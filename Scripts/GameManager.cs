using UnityEngine;

public class GameManager : MonoBehaviour
{
  
    float scoreTimer = 0;
    float scoreTimerMax = 0.9f;
    int health = 50;
    int score = 0;


    

    public UnityAction<int> OnHealthChanged;
    public UnityAction<int> OnScoreChanged;

    private void Start()
    {
        health = 100;
        score = 0;
        OnHealthChanged?.Invoke(health);
        OnScoreChanged?.Invoke(score);
    }

    public void IncreaseHealth()
    {
        health += 10;
        Mathf.Clamp(health, 0, 100);
        OnHealthChanged?.Invoke(health);
    }

    public void IncreaseScore()
    {
        score++;
        OnScoreChanged?.Invoke(score);
    }

    public void DecreaseScore()
    {
        score--;
        OnScoreChanged?.Invoke(score);
    }

    private void OnHealthChanged(float currentHealth, float maxHealth)
    {
        healthText.text = $"{currentHealth}/{maxHealth}";
        healthFill.fillAmount = currentHealth / maxHealth;
    }

    private void OnScoreChanged(float newScore)
    {
        scoreText.text = $"Score: {newScore}";
    }
}  

