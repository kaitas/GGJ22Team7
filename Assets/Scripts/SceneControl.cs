using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// �V�[���`�F���W�֐�
    /// </summary>
    /// <param name="SceneName">�V�[����</param>
    public void SceneChange(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }

}
