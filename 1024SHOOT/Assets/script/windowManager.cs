using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class windowManager : MonoBehaviour
{
    public Camera cam;

    public static int ScreenWidth=Screen.width;
    public static int ScreenHeight=Screen.height;

    private void Start()
    {
  
        cam.aspect = 1080f / 1920f;
    }

}
