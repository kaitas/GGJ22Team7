using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 
/// �f�o�b�O��UI�ŕ\������N���X
/// 
/// </summary>
[System.Serializable]
public class DebugUIOperation
{
    [SerializeReference] Text _debug_text; //�f�o�b�O�ŕ\��������UI�̃e�L�X�g

    //float��\��
    public void View_flo (float value)
    {
        _debug_text.text = "Date since the world began:"+value.ToString(); //���E���n�܂��Ă���̓��t
    }
}
