using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

    void Start()
    {
        LoadRandomCharacterScene();
    }
    
    public void LoadSceneByIndex(int sceneIndex)
    {
        Debug.Log("Load scene # " + sceneIndex);

        SceneManager.LoadScene(sceneIndex);
    }

    void LoadRandomCharacterScene()
    {
        Random.seed = System.DateTime.UtcNow.Millisecond;
        int randomSceneIndex = Random.Range(1, SceneManager.sceneCountInBuildSettings);
        LoadSceneByIndex(randomSceneIndex);
    }
}
