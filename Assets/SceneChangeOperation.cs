using UnityEngine.SceneManagement;

public class SceneChangeOperation
{
    /// <summary>
    /// �V�[���`�F���W�֐�
    /// </summary>
    /// <param name="SceneName">�V�[����</param>
    void SceneChange (string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }
}
