using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float pipeMoveSpeed = 7;
    public float deadZone = -45;
    public LogicScript logic;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(logic.playerScore > 5)
        {
            pipeMoveSpeed = 15;
        }

        transform.position += (Vector3.left * pipeMoveSpeed) * Time.deltaTime;

        if(transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
