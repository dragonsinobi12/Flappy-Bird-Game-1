using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
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
        
    }
}
