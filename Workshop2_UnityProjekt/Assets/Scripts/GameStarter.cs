using UnityEngine;

public class GameStarter : MonoBehaviour
{
    private void Start()
    {
        Time.timeScale = 0f;
    }

    public void StartGame()
    {
        Time.timeScale = 1f;
    }
}
