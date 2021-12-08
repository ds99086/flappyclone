using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUp : MonoBehaviour
{
        //bring score variable from Score and increase by one.
        private void OnTriggerEnter2D(Collider2D other) {
            Score.score +=1;
        }

    
    
}
