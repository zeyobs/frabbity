using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{

    public GameObject prefab;
    public float spawnRate = 2;
    public float minHeight = -5;
    public float maxHeight = 5;

    void OnEnable()
    {
        InvokeRepeating(nameof(spawnPipe), spawnRate,spawnRate);
    }

    private void OnDisable()
    {
        CancelInvoke(nameof(spawnPipe));
    }

    private void spawnPipe()
    {
        GameObject pipes = Instantiate(prefab, transform.position, Quaternion.identity);
        pipes.transform.position += Vector3.up * Random.Range(minHeight, maxHeight);
    }

}


