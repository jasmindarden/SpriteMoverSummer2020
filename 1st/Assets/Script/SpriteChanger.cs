using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChanger : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color color;
    
    void Awake()
    {

    }
   
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.color = color;
    }

    // Update is called once per frame
    void Update()
    {
        //spriteRenderer.color = color;
    }

    /// <summary>
    /// Change the color of the sprite to the color input
    /// </summary>
    
    public void SampleMethod(Color newColor)
    {
        spriteRenderer.color = newColor;
    }


}
