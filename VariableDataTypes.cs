using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    int x = 4;//integer data type
    // public int x; //can also provide access modifier before data type private/public etc private by default
    float y = 3.14f; //float data type
    bool t = true;

    public string myString;
    // Start is called before the first frame update
    void Start()
    {
       Debug.Log("The value of x is: "+x);
       Debug.Log("The value of y is: "+y);
       Debug.Log("The value of t is: "+t);
       Debug.Log("The value of myString is: "+myString);     


    }
    // Update is called once per frame 
    void Update()
    {
        
    }
}
