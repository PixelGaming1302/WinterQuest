using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    [SerializeField] private string sceneToLoad;

    public void LoadScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }

    public void LoadSceneByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
