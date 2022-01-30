<<<<<<< Updated upstream
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;    //fileを読むのに使います
// 地面のセル（盤面）を管理するクラス
public class Cell : MonoBehaviour
{
    // Cellを宣言
//    public int[][] _c; //maxは仮です。重かったら調整。
    TextAsset _tsvFile; // TSVファイル
    List<string[]> _tsvDatas = new List<string[]>(); // TSVの中身を入れるリスト;

    // Start is called before the first frame update
    void Start()
    {
        //TestData.tsv を読んで配列 int _c[][] に格納
        //参考: https://note.com/macgyverthink/n/n83943f3bad60
        Debug.Log("tsvFile loading...");
        _tsvFile = Resources.Load("TestData") as TextAsset; // Resouces下のTSV読み込み(拡張子はTestData.txtにする)
        StringReader reader = new StringReader(_tsvFile.text);

        // \t で分割しつつ一行ずつ読み込み
        // リストに追加していく
        while (reader.Peek() != -1) // reader.Peekが-1になるまで
        {
            string line = reader.ReadLine(); // 一行ずつ読み込み
            _tsvDatas.Add(line.Split('\t')); // タブ区切りでリストに追加
            Debug.Log(line);
        }
        // csvDatas[行][列]を指定して値を自由に取り出せる
        Debug.Log(_tsvDatas[0][1]);
        // cに格納

    }

    // Update is called once per frame
    void Update()
    {
        
=======
using UnityEngine;

/// <summary>
/// 
///  Cellの数値の管理クラス
/// 
/// 2022-01-30
/// tanoue kazuya
/// </summary>
[System.Serializable]
public class Cell
{
    public int _type_int;
    public Transform _cell_tra;
    public bool isNoon;

    public Cell (int _type_int, Transform _cell_tra)
    {
        this._type_int = _type_int;
        this._cell_tra = _cell_tra;
    }

    public Cell(Cell Cell)
    {
        this._type_int = Cell._type_int;
        this._cell_tra = Cell._cell_tra;
>>>>>>> Stashed changes
    }
}
