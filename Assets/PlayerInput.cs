using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] Score scoreScript;
    [SerializeField] ChangeScene sceneChangerScript;
 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            scoreScript.AddPoints(10);
        }

        if(Input.GetKeyDown(KeyCode.Return))
        {
            sceneChangerScript.ChangeSceneSequentially();
        }
    }
}
