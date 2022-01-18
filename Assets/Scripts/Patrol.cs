using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{

    public float speed = 1.0f;
    public Transform[] wayPoints;

    private int current = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Vector2.MoveTowards(transform.position, wayPoints[current].position, speed * Time.deltaTime);
    
        Vector3 dir = wayPoints[current].position - transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        //transform.rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);

        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.AngleAxis(angle - 90, Vector3.forward), 0.05f);

        if (Vector2.Distance(transform.position, wayPoints[current].position) < 0.2)
        {
            current = (current + 1) % wayPoints.Length;
        }
    }
}
