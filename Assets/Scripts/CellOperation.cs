using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
///  ステージのCell関係の管理クラス
/// 
/// 2022-01-30
/// tanoue kazuya
/// </summary>
[System.Serializable]
public class CellOperation
{

    [SerializeField] Transform _cells_parent;       //_cellsの親オブジェクト
    [SerializeField] public List<Cell> _cells;
    [SerializeField] int _cell_Length = 100;        //cellの合計の長さ

    [SerializeField] List<int> _cellsType_ints;


    //ステージの種類
    public enum _cellType
    {
        Sea,
        Rock,
        Desert,
        Land,
        FatLand,
        Grass,
        Forest,
        House
    }

    //向きの順
    public enum Direction
    {
        Left,
        Right,
        Up,
        Down
    }

    //Listのi_cell番のセルの日照時間の更新処理
    public void UpdateCellTime (int i_cell, float totaltime)
    {
        Vector2Int vec2int_cell = Convert_int_to_Vec2int(i_cell);

        float cell_Yaxis_relativePosition = (float)vec2int_cell.y * (1.0f / (float)_cell_Length);
        //24時間を0~1で算出
        float dayTime = totaltime - Mathf.Floor(totaltime);
        float cell_daytime = dayTime + cell_Yaxis_relativePosition;
        //24時間を0~1で算出
        cell_daytime = Mathf.Floor(cell_daytime);

        //午後ならtrue
        _cells[i_cell].isNoon = (cell_daytime > 0.50f);
    }


    // Start is called before the first frame update
    public void Start()
    {
        //_cellsの中身を取得
        _cells = GetCell_list(_cellsType_ints);

    }

    // Update is called once per frame
    public void Update()
    {
        
    }



    public List<Cell> GetCell_list(List<int> cell_type_ints)
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
        _cell.position = new Vector3(x - _cell_Length / 2, 6, z - _cell_Length / 2);
    }

    Vector2Int Convert_int_to_Vec2int (int i)
    {
        int x = (i + 1) % _cell_Length;
        int y = (i + 1) / _cell_Length;
        if (x == 0) x = _cell_Length;
        return new Vector2Int(x, y);
    }
}
