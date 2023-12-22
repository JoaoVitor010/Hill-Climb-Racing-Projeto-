using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    private Transform carro;
    public float smooth;
    
    // Start is called before the first frame update
    void Start()
    {
        carro = GameObject.FindGameObjectWithTag("Carro").transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 following = new Vector3(carro.position.x, carro.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position,following, smooth * Time.deltaTime);
    }
}
