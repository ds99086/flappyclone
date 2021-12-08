using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdJump : MonoBehaviour
{

    //bring rigidbody 2D of the bird to change the vector once touched.
    //to do this, we make a rigidbody class object.
    Rigidbody2D rigidBody;
    //public variables are editable outside the IDE, 
    //can edit the value in the unity editor
    public float jumpPower;

    // Start is called only once, before the first frame update
    void Start() {
        //bring rigidbody 2D component into rigidbody variable.
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called many times, once per frame
    void Update() {
        //use velocity attribute in rgidbody. 
        //change velocity upwards, powered by 3. 
        if(Input.GetMouseButtonDown(0)) {
            rigidBody.velocity = Vector2.up * 3; //(0,1)
        }
    }
        //bring colliders in
        //if  collision, use Scene manager give scene name or number order in parameter
        //Makesure this scene is built in  export
        private void OnCollisionEnter2D(Collision2D other) {
            
            if(Score.score > Score.bestScore) {
                Score.bestScore = Score.score;
            }
            SceneManager.LoadScene("GameOverScene");
        }
}