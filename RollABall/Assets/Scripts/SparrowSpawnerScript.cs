using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SparrowSpawnerScript : MonoBehaviour
{
    private float time = 0.0f;
    public float time_limit = 0.2f;

    public GameObject[] sparrows;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        time += Time.deltaTime;
        if(time >= time_limit)
        {
            time = 0.0f;

            int random_index = Random.Range(0, sparrows.Length);
            Vector3 random_spawn_position = new Vector3(Random.Range(-10, 10), 5, Random.Range(-10, 10));

            Instantiate(sparrows[random_index], random_spawn_position, Quaternion.identity);
        }
    }
}
