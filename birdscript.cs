using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdscript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrenght;
    public logicscript logic;
    public bool alive = true;
    public AudioSource flapSound;
    // Start is called before the first frame update
    void Start()
    {
     logic = GameObject.FindWithTag("logic").GetComponent<logicscript>();

    }

    // Update is called once per frame
void Update()
{ if (Input.GetKeyDown(KeyCode.Space) == true && alive ==true)
    { myRigidbody.velocity = Vector2.up * flapStrenght;
        flapSound.Play();
    }
    
}
private void OnCollisionEnter2D(Collision2D collision)
{
    if (logic != null)
    {
        logic.isGameOver();
    }
    alive = false;
}
private void OnBecameInvisible()
{
    if (logic != null)
    {
        logic.isGameOver();
    }
    alive = false;
}
}
