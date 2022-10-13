using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    [SerializeField] string[] sceneNames;
    [SerializeField] int sceneIndex;
    // Start is called before the first frame update
    void Start()
    {
        sceneIndex = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void ChangeSceneSequentially()
    {
        if(sceneIndex >= sceneNames.Length)
        {
            sceneIndex = 0;
        }
            ChangeSceneAndIncrementIndex();
    }

    void ChangeSceneAndIncrementIndex()
    {
        SceneManager.LoadScene(sceneNames[sceneIndex]);
        sceneIndex++;
    }
}
