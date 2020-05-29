using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject objectToDeactivate;
    public SpriteMover componentToDisable;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    //Exits the game when you press escape
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
      //While the P key pressed, it disables the sprite and no movements can be made. Press P again to unable it
        if (Input.GetKeyDown(KeyCode.P))
        {
            componentToDisable.enabled = !componentToDisable.enabled;
        }

        //While the Q key is held down, it disables the sprite and makes it disappear
        if (Input.GetKeyDown(KeyCode.Q))
        {
            objectToDeactivate.SetActive(!objectToDeactivate.activeInHierarchy);
        }
    }
}
