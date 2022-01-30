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
    //[SerializeField] CellOperation CellOperation;       //セルの管理クラス      //Cellの生成を作ってもらったので、取得方法を新しくする

    public float _totalTime;

    // Start is called before the first frame update
    void Start()
    {
        TimeController.Start();
        //CellOperation.Start();  //Cellの生成を作ってもらったので、取得方法を新しくする
    }

    // Update is called once per frame
    void Update()
    {
        //プレイヤーの操作
        TimeController.Update();
        //経過時間の取得
        _totalTime = TimeController.GetTotalTime();

        //セルの時間の更新
        //Cellの生成を作ってもらったので、取得方法を新しくする
        //for (int i = 0; i < CellOperation._cells.Count; i++)
        //{
        //    CellOperation.UpdateCellTime(i, _totalTime);
        //}


    }
}