using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class logicscript : MonoBehaviour
{
    public int score;
    public Text scoreText;
    [ContextMenu("Increase score")]
    public void addscore ()
    {
        score = score + 1;
        scoreText.text = score.ToString();
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
