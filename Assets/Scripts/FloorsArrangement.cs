using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class FloorsArrangement
{
    [SerializeField] Transform _CellParameters_parent;       //_CellParametersの親オブジェクト
    [SerializeField] int _CellParameter_Length = 100;        //CellParameterの合計の長さ

    public List<CellParameter> GetCellParameter_list (List<int> CellParameter_type_ints)
    {
        List<CellParameter> return_list = new List<CellParameter>();
        for (var i = 0; i < _CellParameters_parent.childCount; i++)
        {
            Transform child = _CellParameters_parent.GetChild(i);
            child.name = "floor_" + "(" + i + ")";
            Placement(i, child);

            CellParameter tmp = new CellParameter(CellParameter_type_ints[i], child);
            return_list.Add(tmp);
        }
        return return_list;
    }
    void Placement(int i, Transform _CellParameter)
    {
        float x = (i + 1) % _CellParameter_Length;
        float z = (i + 1) / _CellParameter_Length;
        if (x == 0) x = _CellParameter_Length;
        _CellParameter.position = new Vector3(x - _CellParameter_Length/2, 6, z - _CellParameter_Length/2);
    }
}