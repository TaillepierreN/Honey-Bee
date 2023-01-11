using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmokerHandle : MonoBehaviour
{
    bool isPressed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PressHandle()
    {
        if(!isPressed);
        transform.Rotate(new Vector3(-15,0,0));
        isPressed = true;
    }
    public void ReleaseHandle()
    {
        transform.Rotate(new Vector3(15,0,0));
        isPressed = false;
    }
}
