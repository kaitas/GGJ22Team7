using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class CreatureCell : MonoBehaviour
{
    //Cellを宣言
    TextAsset _tsvFile2;//tsvファイル
    List<string[]> _tsvDatas2 = new List<string[]>();//tsvの中身を入れるリスト

    // Start is called before the first frame update
    void Start()
    {
        //CreatureData.tsvを読んで配列のint _c[][]に格納
        Debug.Log("tsvFile loading...");
        _tsvFile2 = Resources.Load("CreatureData") as TextAsset;//Resources下のtsvフォルダを取得
        StringReader reader2 = new StringReader(_tsvFile2.text);

        //リスト化
        while(reader2.Peek() != -1)
        {
            string line = reader2.ReadLine();
            _tsvDatas2.Add(line.Split('t'));
            Debug.Log(line);
        }

        Debug.Log(_tsvDatas2[0][1]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
