using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject pipe;
    public float spawnrate = 3;
    private float timer = 0;
    void spawnPipe()
    {
        Instantiate(pipe, transform.position, transform.rotation);
    }
    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnrate)
        { timer = timer + Time.deltaTime; }
        else
        {
            spawnPipe();
            timer = 0;
        }
    }
}
