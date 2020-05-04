using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovements : MonoBehaviour
{
    private Vector2 targetPos;
    public int Yincrement;
    public Rigidbody2D rigid;
    public int speed;
    public float maxHeight;
    public float minHeight;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

            if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight){
                targetPos = new Vector2(transform.position.x , transform.position.y + Yincrement);
                transform.position = targetPos;
            } else if(Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight){
                targetPos = new Vector2(transform.position.x , transform.position.y - Yincrement);
                transform.position = targetPos;
            }
    }
}
