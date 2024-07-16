using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class functions : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
    Debug.Log(Add(4,5));
    
    }

    // Update is called once per frame
    void Update()
    {
    //  Add(); This will be called every frame   
    }
    // Customised function
    // private by default
    // public void Add()
    // {
    //     int a = 5;
    //     int b = 10;
    //     int sum = a + b;
    //     Debug.Log(sum);
    // }

    public int Add(int a1,int a2){
        int result = a1+a2;
        return result;
    }
}
