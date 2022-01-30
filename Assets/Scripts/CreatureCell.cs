using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class CreatureCell : MonoBehaviour
{
    //Cell��錾
    TextAsset _tsvFile2;//tsv�t�@�C��
    List<string[]> _tsvDatas2 = new List<string[]>();//tsv�̒��g�����郊�X�g

    // Start is called before the first frame update
    void Start()
    {
        //CreatureData.tsv��ǂ�Ŕz���int _c[][]�Ɋi�[
        Debug.Log("tsvFile loading...");
        _tsvFile2 = Resources.Load("CreatureData") as TextAsset;//Resources����tsv�t�H���_���擾
        StringReader reader2 = new StringReader(_tsvFile2.text);

        //���X�g��
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
