using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckCollision : MonoBehaviour
{
    [SerializeField] Text Textmortes;
    public int mortes;
    [SerializeField] Text texto;
    Vector3 startPosition;
    void Start()
    {
        startPosition = transform.position;
    }

    private void Update()
    {
        Textmortes.text = "Mortes: " + mortes;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Obstacle")
        {
            mortes++;
        transform.position = startPosition;

        }
        if(collision.gameObject.tag == "Final")
        {
            texto.enabled = true;
        }
    }
}
