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
        _debug_text.text = "Wheel your sky. \n Date since the world began:"+value.ToString("0.0"); //���E���n�܂��Ă���̓��t
    }
}
