using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeManager : MonoBehaviour
{
    public void quitApplication() {
        Application.Quit();
    }

    public void toHome()
    {
        loadScene("Home");
    }

    public void loadEMDRScene()
    {
        loadScene("EMDR Therapy");
    }

    public void loadPathologyScene()
    {
        loadScene("Pathology");
    }

    public void loadMusicTherapyScene()
    {
        loadScene("Music Therapy");
    }

    public void loadAuralTherapyScene()
    {
        loadScene("Aural Therapy");
    }

    public void loadPuzzleScene()
    {
        loadScene("Puzzle");
    }

    private void loadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
