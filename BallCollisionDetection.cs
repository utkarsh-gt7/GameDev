using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed;

    void Update()
    {
        float horInput = Input.GetAxis("Horizontal");
        float verInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horInput, 0.0f, verInput) * speed * Time.deltaTime;

        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(movement, ForceMode.Impulse);
    }
    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag == "wall"){
            ScoreManager.instance.AddScore(-1);
        }
    }
}
