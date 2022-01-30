using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    /// <summary>
    /// シーンチェンジ関数
    /// </summary>
    /// <param name="SceneName">シーン名</param>
    public void SceneChange(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }

}
