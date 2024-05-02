using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootGold : MonoBehaviour
{
    public Transform shootpoint;
    public GameObject target;
    public Rigidbody2D bullet;


    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.DrawLine(ray.origin, ray.direction * 10, Color.yellow, 5);

            RaycastHit2D hit = Physics2D.GetRayIntersection(ray, Mathf.Infinity);

            if (hit.collider != null) 
            {
                target.transform.position = new Vector2(hit.point.x, hit.point.y);
                Debug.Log(" Hit point : " + hit.point);
            }
        }

    }// Update is called once per frame

}//ShootGold
