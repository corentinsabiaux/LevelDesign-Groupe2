using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTransition : MonoBehaviour
{
    public int sceneToLoad;

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
