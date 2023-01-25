using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipemiddle : MonoBehaviour
{
    public AudioSource sound;
    public logicscript logic;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindWithTag("logic").GetComponent<logicscript>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!logic.gameover)
        {
            if (collision.gameObject.layer == 3)
            {
                logic.addscore(1);
                sound.Play();
            }
        }
        else
        {
            sound.Stop();
        }
    }
}