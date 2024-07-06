using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigibody;
    public bool birdIsAlive = true;
    public LogicScript logicScript;
    void Start()
    {
        logicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        logicScript.addScore();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myRigibody.velocity = Vector2.up * 10;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision2D)
    {
        logicScript.gameOver();
        birdIsAlive = false;
    }
}
