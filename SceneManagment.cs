using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManagment : MonoBehaviour
{
    public static SceneManagment instance;

    private void Awake(){
        if(instance == null){
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}
