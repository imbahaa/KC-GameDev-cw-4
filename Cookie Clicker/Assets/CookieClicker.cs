using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CookieClicker : MonoBehaviour
{

    public int Score = 0;
    public TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void PressMe()
    {
        Score++;
        scoreText.text = "Score" + Score.ToString();
    }

}
