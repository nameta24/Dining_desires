using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public string secondSceneName = "UI 2"; // Name of your second scene.

    void Start()
    {
        StartCoroutine(TransitionToSecondScene());
    }

    IEnumerator TransitionToSecondScene()
    {
        // Wait for 5 seconds before transitioning to the second scene.
        yield return new WaitForSeconds(3.0f);
        SceneManager.LoadScene(secondSceneName);
        
    }

    
}
