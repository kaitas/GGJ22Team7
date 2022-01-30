using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class FloorsArrangement
{
    [SerializeField] Transform _cells_parent;       //_cellsの親オブジェクト
    [SerializeField] int _cell_Length = 100;        //cellの合計の長さ


    public List<Cell> GetCell_list (List<int> cell_type_ints)
    {
        List<Cell> return_list = new List<Cell>();
        for (var i = 0; i < _cells_parent.childCount; i++)
        {
            Transform child = _cells_parent.GetChild(i);
            child.name = "floor_" + "(" + i + ")";
            Placement(i, child);

            Cell tmp = new Cell(cell_type_ints[i], child);
            return_list.Add(tmp);
        }
        return return_list;
    }
    void Placement(int i, Transform _cell)
    {
        float x = (i + 1) % _cell_Length;
        float z = (i + 1) / _cell_Length;
        if (x == 0) x = _cell_Length;
        _cell.position = new Vector3(x - _cell_Length/2, 6, z - _cell_Length/2);
    }
}