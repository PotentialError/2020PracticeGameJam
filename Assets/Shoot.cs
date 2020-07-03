using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Shoot : MonoBehaviour
{
    public Transform shootPoint;
    public GameObject bullet;
    public Camera cam;
    public Vector2 mousePos;
    public GameObject fire;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetKeyDown("e"))
        {
            Shooting();
        }
    }
    private void Shooting()
    {
        Instantiate(fire, shootPoint.position, shootPoint.rotation);
        Instantiate(bullet, shootPoint.position, shootPoint.rotation);
    }
    private void FixedUpdate()
    {
        Vector2 currentPos = shootPoint.position;
        Vector3 lookDir = mousePos - currentPos;
        if (lookDir.x < 0f && Mathf.Abs(lookDir.x) > 1f)
        {
            transform.eulerAngles = new Vector3(0, -180, 0);
        }
        else if (lookDir.x > 0f && Mathf.Abs(lookDir.x) > 1f)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        shootPoint.eulerAngles = new Vector3(0, 0, Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg);
    }
}
