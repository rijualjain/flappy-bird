using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logicscript : MonoBehaviour
{
    public int score;
    public Text scoreText;
    public GameObject gameoverscreen;
    public bool gameover = false;

    [ContextMenu("Increase score")]
    public void addscore(int scoretoadd)
    {
        if (!gameover)
        {
            score = score + scoretoadd;
            scoreText.text = score.ToString();
        }
    }
    public void restartgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void isGameOver()
    {
        gameover = true;
        gameoverscreen.SetActive(true);
    }
}