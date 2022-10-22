using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CookieClicker : MonoBehaviour
{

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI levelText;
    public int Score = 0;
    public int level = 1;
    public AudioSource source;
    public AudioClip clip;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void PressMe()
    {
        if (Score == 10 * level - 1)
        {
            source.PlayOneShot(clip);
            level++;
            Score++;
            levelText.text = "Level: " + level.ToString();
            scoreText.text = "Score: " + Score.ToString();
        }
        else
        {
            Score++;
            scoreText.text = "Score: " + Score.ToString();
        }

    }

}
