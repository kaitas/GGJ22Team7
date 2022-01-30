using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCell : MonoBehaviour
{
    public GameObject Cell;
    public List<GameObject[]> _cell_list;
    public int _cell_y;@//‚Æ‚è‚ ‚¦‚¸‚‚³‚ğ’²®‚Å‚«‚é

    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(Cell, new Vector3 (0,0,0) , Quaternion.Euler(90,0,0));
        _cell_list = new List<GameObject[]>();
        for (int x = -50; x <= 50; x++)
        {
            int Yaxis_count = 0;
            GameObject[] cell_Yaxis_objs = new GameObject[100];
            for (int y = -50; y <= 50; y++)
            {
                GameObject clone = Instantiate(Cell, new Vector3(x, _cell_y, y), Quaternion.Euler(90, 0, 0));
                cell_Yaxis_objs[Yaxis_count] = clone;

            }
            _cell_list.Add(cell_Yaxis_objs);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
