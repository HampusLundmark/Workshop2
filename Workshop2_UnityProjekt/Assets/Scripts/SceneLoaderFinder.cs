using UnityEngine;

public class SceneLoaderFinder : MonoBehaviour
{
    SceneLoader sceneLoader;

    private void Start()
    {
        sceneLoader = FindFirstObjectByType<SceneLoader>();
    }

    public void LoadScene(int buildIndex)
    {
        sceneLoader.LoadScene(buildIndex);
    }

    public void ReloadScene()
    {
        sceneLoader.ReloadScene();
    }

    public void QuitGame()
    {
        sceneLoader.QuitGame();
    }
}
