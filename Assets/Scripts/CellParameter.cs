using UnityEngine;
/// <summary>
/// 
///  Cell�̐��l�̊Ǘ��N���X
/// 
/// 2022-01-30
/// tanoue kazuya
/// </summary>
[System.Serializable]
public class CellParameter : MonoBehaviour
{


    public int _type_int;
    public Transform _cell_tra;
    public bool isNoon;

    public CellParameter(int _type_int, Transform _cell_tra)
    {
        this._type_int = _type_int;
        this._cell_tra = _cell_tra;
    }

    public CellParameter(CellParameter CellParameter)
    {
        this._type_int = CellParameter._type_int;
        this._cell_tra = CellParameter._cell_tra;
    } 
}
