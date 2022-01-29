using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CameraOperation
{
    Camera maincam;
    Transform Yaxis;
    Transform Xaxis;
    Transform Zaxis;

    Vector3 mouse_pos;
    Vector3 mouse_pos_diff;
    [SerializeField] float Cam_Speed_Rate = 0.010f;
    // Start is called before the first frame update
    public void Start()
    {
        maincam = Camera.main;
        Zaxis = maincam.transform.parent;
        Xaxis = Zaxis.parent;
        Yaxis = Xaxis.parent;
    }

    // Update is called once per frame
    public void Update()
    {
        mouse_pos = Input.mousePosition;
        Vector3 diff = mouse_pos - mouse_pos_diff;
        mouse_pos_diff = mouse_pos;
        Yaxis.Rotate(0.0f, diff.x * Cam_Speed_Rate, 0.0f);
        Xaxis.Rotate(diff.y * Cam_Speed_Rate, 0.0f, 0.0f);

    }
}
