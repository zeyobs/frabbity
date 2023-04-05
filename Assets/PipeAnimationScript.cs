using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeAnimationScript : MonoBehaviour
{

    public float moveSpeed = 5;
    public double deadZone = -6.4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
            Debug.Log("Pipe Deleted");
        }
    }
}
