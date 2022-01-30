using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCell : MonoBehaviour
{
    public GameObject Cell;
    public List<GameObject[]> _cell_list;
    public int _cell_y;　//とりあえず高さを調整できる
    public Vector2Int _cellOffset_vec2int = new Vector2Int(-50,-50);
    public int _cellLength = 100;


    public GameObject _Cell_obj;        //セルを処理をアタッチされているGameObject
    Cell _Cell_cls;                         //セルのフィールドデータ
    Material[] _CellMaterials;

    // Start is called before the first frame update
    void Start()
    {
        //_Cell_clsの_tsvDatasを取得
        if (_Cell_obj == null) { _Cell_obj = this.gameObject; }
        _Cell_cls = _Cell_obj.GetComponent<Cell>();
        List<string[]> tsvDatas_list = _Cell_cls._tsvDatas;



        //
        _CellMaterials = Resources.LoadAll<Material>("CellMaterials");


        //_cell_listを生成
        _cell_list = new List<GameObject[]>();
        for (int x = 0; x < _cellLength; x++)
        {
            GameObject[] cell_Yaxis_objs = new GameObject[_cellLength];
            for (int y = 0; y < _cellLength; y++)
            {
                GameObject clone = 
                    Instantiate(
                        Cell,
                        new Vector3(x + _cellOffset_vec2int.x, _cell_y, y + _cellOffset_vec2int.y),
                        Quaternion.Euler(90, 0, 0));

                cell_Yaxis_objs[y] = clone;

                //_tsvDatasを参照してMaterialをアタッチ
                string tsvData_str = tsvDatas_list[x][y];
                if (tsvData_str == null) { tsvData_str = "0"; }
                int tsvData_str_Convert_int;
                try
                {
                    tsvData_str_Convert_int = int.Parse(tsvData_str);
                }
                catch
                {
                    tsvData_str_Convert_int = 0;
                }
                if (tsvData_str_Convert_int >= _CellMaterials.Length)
                {
                    tsvData_str_Convert_int = 0;
                }

                clone.GetComponent<Renderer>().material = _CellMaterials[tsvData_str_Convert_int];
            }
            _cell_list.Add(cell_Yaxis_objs);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
