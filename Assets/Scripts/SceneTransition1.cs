using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition1 : MonoBehaviour
{
    public string thirdSceneName = "AR scene"; // Name of your second scene.

    void Start()
    {
        StartCoroutine(TransitionToThirdScene());
    }

    IEnumerator TransitionToThirdScene()
    {
        // Wait for 5 seconds before transitioning to the second scene.
        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene(thirdSceneName);
        
    }

    
}
