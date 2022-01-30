using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCell : MonoBehaviour
{
    public GameObject Cell;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Cell,new Vector3 (0,0,0), Quaternion.Euler(90,0,0));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
