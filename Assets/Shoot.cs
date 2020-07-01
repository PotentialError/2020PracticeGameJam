using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform shootPoint;
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            Shooting();
        }
    }
    private void Shooting()
    {
        Instantiate(bullet, shootPoint.position, shootPoint.rotation);
    }
}
