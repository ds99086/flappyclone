using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePipe : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Bring transform component and change  z  it's preexisting component
        //Vector3.left is (-1),0,0) moves one position per frame 
        //WARNING it will appear in different speed in different FPS rate.
        //need to adjust it with Time.deltaTime 
        transform.position += (Vector3.left * Time.deltaTime * speed);
        
    }
}
