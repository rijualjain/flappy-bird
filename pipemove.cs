using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipemove : MonoBehaviour
{
    public float movespeed = 5;
    public float deadzone = 0.13f;
    public float deadzonebuf = 1f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * movespeed) * Time.deltaTime;
        if (deadzone > transform.position.x + deadzonebuf  )
        {
            Destroy(gameObject);
        }
    }
}
