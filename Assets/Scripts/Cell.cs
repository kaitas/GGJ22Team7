<<<<<<< Updated upstream
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;    //file��ǂނ̂Ɏg���܂�
// �n�ʂ̃Z���i�Ֆʁj���Ǘ�����N���X
public class Cell : MonoBehaviour
{
    // Cell��錾
//    public int[][] _c; //max�͉��ł��B�d�������璲���B
    TextAsset _tsvFile; // TSV�t�@�C��
    List<string[]> _tsvDatas = new List<string[]>(); // TSV�̒��g�����郊�X�g;

    // Start is called before the first frame update
    void Start()
    {
        //TestData.tsv ��ǂ�Ŕz�� int _c[][] �Ɋi�[
        //�Q�l: https://note.com/macgyverthink/n/n83943f3bad60
        Debug.Log("tsvFile loading...");
        _tsvFile = Resources.Load("TestData") as TextAsset; // Resouces����TSV�ǂݍ���(�g���q��TestData.txt�ɂ���)
        StringReader reader = new StringReader(_tsvFile.text);

        // \t �ŕ�������s���ǂݍ���
        // ���X�g�ɒǉ����Ă���
        while (reader.Peek() != -1) // reader.Peek��-1�ɂȂ�܂�
        {
            string line = reader.ReadLine(); // ��s���ǂݍ���
            _tsvDatas.Add(line.Split('\t')); // �^�u��؂�Ń��X�g�ɒǉ�
            Debug.Log(line);
        }
        // csvDatas[�s][��]���w�肵�Ēl�����R�Ɏ��o����
        Debug.Log(_tsvDatas[0][1]);
        // c�Ɋi�[

    }

    // Update is called once per frame
    void Update()
    {
        
=======
using UnityEngine;

/// <summary>
/// 
///  Cell�̐��l�̊Ǘ��N���X
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
