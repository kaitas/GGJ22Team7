using UnityEngine.SceneManagement;

public class SceneChangeOperation
{
    void SceneChange (string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }
}
