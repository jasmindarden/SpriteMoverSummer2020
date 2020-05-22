using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class SpriteMover : MonoBehaviour
{
    public float moveSpeed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //It will move the Beachball Sprite right constantly to set speed (1 unit)
        transform.position += Vector3.right * moveSpeed * Time.deltaTime;
    }
}
