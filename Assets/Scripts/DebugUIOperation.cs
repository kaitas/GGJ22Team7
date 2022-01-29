using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 
/// デバッグをUIで表示するクラス
/// 
/// </summary>
[System.Serializable]
public class DebugUIOperation
{
    [SerializeReference] Text _debug_text; //デバッグで表示したいUIのテキスト

    //floatを表示
    public void View_flo (float value)
    {
        _debug_text.text = "Date since the world began:"+value.ToString(); //世界が始まってからの日付
    }
}
