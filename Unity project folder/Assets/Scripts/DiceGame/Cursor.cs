using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour
{
    public static bool visible;
    internal static CursorLockMode lockState;


    // Start is called before the first frame update
    void Start()
    {
        Screen.lockCursor = false;
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
}
