using UnityEngine;
using TMPro;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    public TMP_Text scoreText;
    public Renderer targetRenderer;

    private Color originalColor;

    void Start()
    {
        if (targetRenderer != null)
        {
            originalColor = targetRenderer.material.color;
        }

        UpdateScoreText();
    }

    public void AddPoint()
    {
        score++;
        UpdateScoreText();

        if (targetRenderer != null)
        {
            StopAllCoroutines();
            StartCoroutine(ShowSuccessEffect());
        }
    }

    void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Puntos: " + score;
        }
    }

    IEnumerator ShowSuccessEffect()
    {
        targetRenderer.material.color = Color.green;
        yield return new WaitForSeconds(0.5f);

        targetRenderer.material.color = originalColor;
    }
}