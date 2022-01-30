using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
///  �X�e�[�W��Cell�֌W�̊Ǘ��N���X
/// 
/// 2022-01-30
/// tanoue kazuya
/// </summary>
[System.Serializable]
public class CellOperation
{

    [SerializeField] Transform _cells_parent;       //_cells�̐e�I�u�W�F�N�g
    [SerializeField] public List<Cell> _cells;
    [SerializeField] int _cell_Length = 100;        //cell�̍��v�̒���

    [SerializeField] List<int> _cellsType_ints;


    //�X�e�[�W�̎��
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

    //�����̏�
    public enum Direction
    {
        Left,
        Right,
        Up,
        Down
    }

    //List��i_cell�Ԃ̃Z���̓��Ǝ��Ԃ̍X�V����
    public void UpdateCellTime (int i_cell, float totaltime)
    {
        Vector2Int vec2int_cell = Convert_int_to_Vec2int(i_cell);

        float cell_Yaxis_relativePosition = (float)vec2int_cell.y * (1.0f / (float)_cell_Length);
        //24���Ԃ�0~1�ŎZ�o
        float dayTime = totaltime - Mathf.Floor(totaltime);
        float cell_daytime = dayTime + cell_Yaxis_relativePosition;
        //24���Ԃ�0~1�ŎZ�o
        cell_daytime = Mathf.Floor(cell_daytime);

        //�ߌ�Ȃ�true
        _cells[i_cell].isNoon = (cell_daytime > 0.50f);
    }


    // Start is called before the first frame update
    public void Start()
    {
        //_cells�̒��g���擾
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
