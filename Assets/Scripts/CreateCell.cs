using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCell : MonoBehaviour
{
    public GameObject Cell;

    public int _cell_y;@//‚Æ‚è‚ ‚¦‚¸‚‚³‚ğ’²®‚Å‚«‚é

    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(Cell, new Vector3 (0,0,0) , Quaternion.Euler(90,0,0));

        for (int x = -50; x <= 50; x++)
        {
            for (int y = -50; y <= 50; y++)
            {
                Instantiate(Cell, new Vector3(x, _cell_y, y), Quaternion.Euler(90, 0, 0));
            }
        }

        //GameObject.FindWithTag("floor");

    }

    // Update is called once per frame
    void Update()
    {

    }
}
