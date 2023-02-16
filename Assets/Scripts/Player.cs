using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float velocity = 4f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal") * velocity * Time.deltaTime;
        float moveY = Input.GetAxis("Vertical") * velocity * Time.deltaTime;

        transform.Translate(moveX, 0, moveY);   
    }
}
