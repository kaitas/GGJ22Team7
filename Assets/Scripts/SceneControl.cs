using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    /// <summary>
    /// �V�[���`�F���W�֐�
    /// </summary>
    /// <param name="SceneName">�V�[����</param>
    public void SceneChange(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }

}
