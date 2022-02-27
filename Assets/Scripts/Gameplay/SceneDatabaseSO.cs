using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(fileName = "SceneDB", menuName = "Gameplay/SceneDatabase")]
public class SceneDatabaseSO : ScriptableObject
{
    // Cleaner way to do this using lists and scene scriptable objects
    public enum Scenes
    {
        MAINMENU,
        GAMEPLAY,
        GAMEOVER
    }

    public void LoadGameOver()
    {
        LoadSceneFromIndex(Scenes.GAMEOVER);
    }

    public void LoadGame()
    {
        LoadSceneFromIndex(Scenes.GAMEPLAY);
    }

    public void Restart()
    {
        LoadSceneFromIndex(Scenes.MAINMENU);
    }

    public void LoadSceneFromIndex(Scenes level)
    {
        SceneManager.LoadScene((int)level);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
