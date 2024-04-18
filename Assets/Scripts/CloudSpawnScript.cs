using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawnScript : MonoBehaviour
{
    public GameObject cloud;
    public float spawnRate = 2;
    public float timer = 0;
    public float heightOffset = 14;

    // Start is called before the first frame update
    void Start()
    {
        spawnCloud();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnCloud();
            timer = 0;
        }
    }

    void spawnCloud()
    {
        float lowerOffset = transform.position.y - heightOffset;
        float higherOffset = transform.position.y + heightOffset;

        Instantiate(cloud, new Vector3(transform.position.x, Random.Range(lowerOffset, higherOffset), transform.position.z), transform.rotation);
    }
}
