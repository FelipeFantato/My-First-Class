using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingCube : MonoBehaviour
{
    MeshRenderer m_MeshRenderer;
    [SerializeField] private Rigidbody rb;

    
    // Start is called before the first frame update
    void Start()
    {
        m_MeshRenderer = GetComponent<MeshRenderer>();
        m_MeshRenderer.enabled = false;
        rb.useGravity = false;
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > Random.Range(1,3))
        {
            rb.useGravity = true;
            m_MeshRenderer.enabled = true;
        }
    }

    
}
