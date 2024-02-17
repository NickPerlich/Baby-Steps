using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    [SerializeField] GameObject pipes;
    [SerializeField] float spawnRate = 2;
    private float timer = 0;
    [SerializeField] float heightOffset = 10;

    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        // if the timer hasn't reached the spawn rate increment the timer, otherwise spawn a set of pipes
        if (timer < spawnRate) {
            timer += Time.deltaTime;
        }
        else {
            SpawnPipe();
            timer = 0;
        }
    }

    void SpawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float heighestPoint = transform.position.y + heightOffset;

        Instantiate(pipes, new Vector3(transform.position.x, Random.Range(lowestPoint, heighestPoint), 0), transform.rotation);
    }
}
