using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdscript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrenght;
    public logicscript logic;
    // Start is called before the first frame update
    void Start()
    {
     logic = GameObject.FindWithTag("logic").GetComponent<logicscript>();

    }

    // Update is called once per frame
    void Update()
    { if (Input.GetKeyDown(KeyCode.Space) == true)
        { myRigidbody.velocity = Vector2.up * flapStrenght;
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameover();
    }
}
