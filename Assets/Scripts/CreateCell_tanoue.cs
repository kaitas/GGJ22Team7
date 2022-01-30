using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCell_tanoue : MonoBehaviour
{
    public Transform _cellParent_tras;
    public GameObject _cell_obj;
    public int _cells_Length = 100;
    public List<GameObject> _cell_list;

    public DebugUIOperation[] DebugUIOperation;

    // Start is called before the first frame update
    void Start()
    {
        //    int Debug_x_int = 0;
        //    int Debug_y_int = 0;

        _cell_list = new List<GameObject>();
        for (int x_i = 0; x_i < _cells_Length; x_i++)
        {
            for (int y_i = 0; y_i < _cells_Length; y_i++)
            {
                GameObject create_cell = Instantiate(_cell_obj);
                Placement(x_i, y_i, create_cell.transform);
                create_cell.transform.parent = _cellParent_tras;
                _cell_list.Add(create_cell);

                Debug.Log("x : " + x_i + "    y : " + y_i);

                //Debug_x_int = x_i;
                //Debug_y_int = y_i;
            }
        }

        //DebugUIOperation[0].View_flo(Debug_x_int);
        //DebugUIOperation[1].View_flo(Debug_y_int);
    }

    //public List<CellParameter> GetCell_list(List<int> cell_type_ints)
    //{
    //    List<CellParameter> return_list = new List<CellParameter>();
    //    for (var i = 0; i < _cells_parent.childCount; i++)
    //    {
    //        Transform child = _cells_parent.GetChild(i);
    //        child.name = "floor_" + "(" + i + ")";
    //        Placement(i, child);

    //        CellParameter tmp = new CellParameter(cell_type_ints[i], child);
    //        return_list.Add(tmp);
    //    }
    //    return return_list;
    //}
    void Placement(int x_i,int y_i, Transform _cell)
    {
        float x = ((float)x_i + 1.0f) % _cells_Length;
        float z = ((float)y_i + 1.0f) / _cells_Length;
        if (x == 0) x = _cells_Length;
        _cell.position = new Vector3(x - _cells_Length / 2, 6, z - _cells_Length / 2);
    }

    Vector2Int Convert_int_to_Vec2int(int i)
    {
        int x = (i + 1) % _cells_Length;
        int y = (i + 1) / _cells_Length;
        if (x == 0) x = _cells_Length;
        return new Vector2Int(x, y);
    }
}
