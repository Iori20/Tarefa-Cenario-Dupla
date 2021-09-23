using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMov : MonoBehaviour
{
    public bool lockMouse = true;
    public float sense = 2.0f;

    float mouseX = 0.0f, mouseY = 0.0f;


    // Start is called before the first frame update
    void Start()
    {
        if (lockMouse)
        {
            return;
        }
    }

    // Update is called once per frame
    void Update()
    {
        mouseX += Input.GetAxis("Mouse X") * sense;
        mouseY -= Input.GetAxis("Mouse Y") * sense;

        transform.eulerAngles = new Vector3(mouseY, mouseX, 0);

    }
}
