using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class FadeScript : MonoBehaviour
{
    public float targetAlpha = 256f; 
    public float duration = 2f; // Duration in seconds

    private float currentAlpha;
    private float timer;
    public Image panelImage;

    private void Start()
    {
       
        currentAlpha = panelImage.color.a;
        timer = 0f;
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            timer += Time.deltaTime;
            float normalizedTime = Mathf.Clamp01(timer / duration);

            // Calculate the new alpha value using Lerp
            float newAlpha = Mathf.Lerp(currentAlpha, targetAlpha, normalizedTime);

            // Update the panel's alpha value
            Color color = panelImage.color;
            color.a = newAlpha;
            panelImage.color = color;

            if (normalizedTime >= 1f)
            {
                SceneManager.LoadScene("MainGame");
            }
        }


    }

}
