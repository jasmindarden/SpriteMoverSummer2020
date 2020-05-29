using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class SpriteMover : MonoBehaviour
{
    public float moveSpeed = 0.1f;
    public float shiftSpeed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //It will move the beachball sprite right when we hold the right key to set speed (1 unit)
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //It will move the beachball sprite when we hold the up key to set speed (1 unit)
            transform.position += Vector3.up * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //It will move the beachball sprite left when we hold the left key to set speed (1 unit)
            transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            //It will move the beachball sprite down when we hold the down key to set speed (1 unit)
            transform.position += Vector3.down * moveSpeed * Time.deltaTime;
        }

        //Moves the sprite back to the origin (0,0)
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position = new Vector3(0.0f, 0.0f, 0.0f);
        }

        //Moves sprite faster when Shift is held down
        if (Input.GetKey(KeyCode.LeftShift))
        {
            moveSpeed = shiftSpeed;
        }
        else 
        {
                moveSpeed = 1f;
        }
    }
}