using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    private SceneLoader sceneLoader = null;
    void Awake(){
        sceneLoader = GameObject.FindWithTag("SceneLoader").GetComponent<SceneLoader>();
    }
    void OnTriggerEnter(Collider col){
        if(col.gameObject.CompareTag("Player")){
            sceneLoader.RestartLevel();
        }
    }
}
