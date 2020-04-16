using UnityEngine;

public class Movement : MonoBehaviour
{

    private KeyCode fwdKey, backKey, leftKey, rightKey;
    private float avgSpeed;
    public Rigidbody player;

    Movement()
    {
        fwdKey = (KeyCode)'w';
        backKey = (KeyCode)'s';
        leftKey = (KeyCode)'a';
        rightKey = (KeyCode)'d';
        avgSpeed = 1200f;

    }
    void FixedUpdate()
    {
        if (Input.GetKey(fwdKey))
            player.AddForce(0, 0, Time.deltaTime * avgSpeed);
        if (Input.GetKey(backKey))
            player.AddForce(0, 0, -(Time.deltaTime * avgSpeed));
        if (Input.GetKey(rightKey))
        player.AddForce(Time.deltaTime * avgSpeed, 0, 0);
        if (Input.GetKey(leftKey))
            player.AddForce(-(Time.deltaTime * avgSpeed), 0 , 0);
    }
}


/*
//UPDATE CONTROLLERS

public void updateController{}
     */