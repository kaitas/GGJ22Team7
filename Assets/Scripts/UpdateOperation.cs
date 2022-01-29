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
    [SerializeField]  TimeController TimeController;
    // Start is called before the first frame update
    void Start()
    {
        TimeController.Start();
    }

    // Update is called once per frame
    void Update()
    {
        TimeController.Update();
    }
}
