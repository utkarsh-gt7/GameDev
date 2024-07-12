using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{

    public GameObject ballPrefab;
    public Transform instantiatePos;


    void Start(){
        Instantiate(ballPrefab, instantiatePos.position, Quaternion.identity);
    }

}
