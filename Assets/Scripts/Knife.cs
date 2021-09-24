using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Knife : MonoBehaviour
{
    private SceneLoader sceneLoader = null;

    void Awake()
    {
        sceneLoader = GameObject.FindWithTag("SceneLoader").GetComponent<SceneLoader>();
    }
    void OnTriggerEnter(Collider colliderInfo)
    {
        if (colliderInfo.gameObject.CompareTag("Player"))
        {
            sceneLoader.RestartLevel();
        }
    }
}
