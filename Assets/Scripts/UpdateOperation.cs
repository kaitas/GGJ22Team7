using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 
///  �Q�[���i�s�̊Ǘ��N���X
/// 
/// ���̂���
/// 2022-01-29
/// </summary>
public class UpdateOperation : MonoBehaviour
{

    [SerializeField] TimeController TimeController;     //����̊Ǘ��N���X
    //[SerializeField] CellOperation CellOperation;       //�Z���̊Ǘ��N���X      //Cell�̐���������Ă�������̂ŁA�擾���@��V��������

    public float _totalTime;

    // Start is called before the first frame update
    void Start()
    {
        TimeController.Start();
        //CellOperation.Start();  //Cell�̐���������Ă�������̂ŁA�擾���@��V��������
    }

    // Update is called once per frame
    void Update()
    {
        //�v���C���[�̑���
        TimeController.Update();
        //�o�ߎ��Ԃ̎擾
        _totalTime = TimeController.GetTotalTime();

        //�Z���̎��Ԃ̍X�V
        //Cell�̐���������Ă�������̂ŁA�擾���@��V��������
        //for (int i = 0; i < CellOperation._cells.Count; i++)
        //{
        //    CellOperation.UpdateCellTime(i, _totalTime);
        //}


    }
}