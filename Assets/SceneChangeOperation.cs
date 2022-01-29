using UnityEngine.SceneManagement;

public class SceneChangeOperation
{
    /// <summary>
    /// シーンチェンジ関数
    /// </summary>
    /// <param name="SceneName">シーン名</param>
    void SceneChange (string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }
}
