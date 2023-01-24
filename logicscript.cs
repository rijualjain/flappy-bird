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
    [ContextMenu("Increase score")]
    public void addscore (int scoretoadd)
    {
        score = score + scoretoadd;
        scoreText.text = score.ToString();
    }
    public void restartgame()
    {
    SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
    }

    public void gameover()
    {
        gameoverscreen.SetActive(true);
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
