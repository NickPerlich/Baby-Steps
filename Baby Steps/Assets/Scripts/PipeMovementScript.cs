using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovementScript : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] float moveSpeed = 5;
    [SerializeField] float leftCameraEdge = -17;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < leftCameraEdge)
        {
            Destroy(gameObject);
        }

        transform.Translate(Vector3.left * Time.deltaTime * moveSpeed);
    }
}
