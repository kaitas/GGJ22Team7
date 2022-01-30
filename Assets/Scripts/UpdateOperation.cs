using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 
///  ゲーム進行の管理クラス
/// 
/// たのうえ
/// 2022-01-29
/// </summary>
public class UpdateOperation : MonoBehaviour
{

    [SerializeField] TimeController TimeController;     //操作の管理クラス
    [SerializeField] CellOperation CellOperation;       //セルの管理クラス

    public float _totalTime;

// Start is called before the first frame update
    void Start()
    {
        TimeController.Start();
        CellOperation.Start();
    }

    // Update is called once per frame
    void Update()
    {
        //プレイヤーの操作
        TimeController.Update();
        //経過時間の取得
        _totalTime = TimeController.GetTotalTime();

        //セルの時間の更新
        for (int i = 0; i < CellOperation._cells.Count; i++)
        {
            CellOperation.UpdateCellTime(i, _totalTime);
        }


    }
}