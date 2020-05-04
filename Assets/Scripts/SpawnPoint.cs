using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public GameObject obstacle;
    private float timeBtwSpawn;
    public float startTimeBtwSpawn;
    public float decreaseTime;
    public float minTime = 0.65f;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(obstacle, transform.position, Quaternion.identity);   
    }

    // Update is called once per frame
    void Update()
    {
        if (timeBtwSpawn <= 0){
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 10);
            Instantiate(obstacle,transform.position,Quaternion.identity);
            timeBtwSpawn = startTimeBtwSpawn;
            /*if (startTimeBtwSpawn > minTime){
                startTimeBtwSpawn -= decreaseTime;
            }*/
        }else {
            timeBtwSpawn -= Time.deltaTime;
        }
    }
}
