using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    //on Unity, you can drag the pipe object to the pipe selection row. 
    public GameObject pipe;
    public float timeDiff;
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //measure when timer reaches 1 = reaches 1 second as deltaTime cumulates.
        //Instantiate(pipe);  
        
        timer += Time.deltaTime;
        if (timer > timeDiff) {
            //instead of instantiate(pipe), store it in a variable
            // then change the position.
          GameObject newpipe = Instantiate(pipe);  
          newpipe.transform.position = new Vector3(Random.Range(2.5f, 4f), Random.Range(-1.0f, 5.0f), 0);
          timer = 0;

        
          Destroy(newpipe, 10.0f);
        }

        //Debug.Log(timer);


        //create a pipe per second
        
    }
}
