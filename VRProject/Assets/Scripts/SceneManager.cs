using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnitySceneManager = UnityEngine.SceneManagement.SceneManager;

public class SceneManager : MonoBehaviour
{
    public KeyCode sceneCampsite;
    public KeyCode sceneFishing;
    public KeyCode sceneSorting;

    // Start is called before the first frame update
    void Start()
    {
        sceneCampsite = KeyCode.Alpha1;
        sceneFishing = KeyCode.Alpha2;
        sceneSorting = KeyCode.Alpha3;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(sceneCampsite))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Campsite");
        } else if( Input.GetKeyDown(sceneFishing))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Fishing");
        } else if(Input.GetKeyDown(sceneSorting))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Sorting");
        }
    }
}
