using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pidtolController : MonoBehaviour
{
    public GameObject bullet, bulletPoition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public  void pistolShot()
    {
        Instantiate(bullet,bulletPoition.transform.position,transform.rotation);
    }
}
