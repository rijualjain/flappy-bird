using System.Collections;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject pipe;
    public float spawnrate = 3;
    public float spawnRateIncrease = 0.01f;
    private float timer = 0;
    public float hightsponer = 10;

    void spawnPipe()
    {
        float lowestpoint = transform.position.y - hightsponer;
        float highestpoint = transform.position.y + hightsponer;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestpoint, highestpoint), transform.position.z), transform.rotation);
    }

    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        spawnrate -= spawnRateIncrease * Time.deltaTime;

        if (timer < spawnrate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }
    }
}

