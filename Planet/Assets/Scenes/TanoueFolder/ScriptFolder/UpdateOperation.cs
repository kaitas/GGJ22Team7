using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateOperation : MonoBehaviour
{
    [SerializeField] CameraOperation CameraOpe;
    // Start is called before the first frame update
    void Start()
    {
        CameraOpe.Start();
    }

    // Update is called once per frame
    void Update()
    {
        CameraOpe.Update();

    }
}
