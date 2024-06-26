using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floatingTarget : MonoBehaviour
{
    public string label;

    static Vector3 center = new Vector3(0, 0, 15);
    static int radius = 10;
    private float startTime;
    private Vector3 startPosition;
    private Vector3 targetPosition;
    private float journeyLength;
    
    private float speed = 1f;

    private Vector3 rotateOffset;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Transform>().position = center;
        startTime = Time.time;
        startPosition = center;
        Vector3 Offset = Random.insideUnitSphere;
        Offset.z = Offset.z / 2;
        targetPosition = center + Offset * radius;
        journeyLength = Vector3.Distance(startPosition, targetPosition);
        rotateOffset = Random.insideUnitSphere * 20;
    }

    // Update is called once per frame
    void Update()
    {
        float distCovered = (Time.time - startTime) * speed;
        float fractionOfJourney = distCovered / journeyLength;

        if (fractionOfJourney > 1)
        { 
            fractionOfJourney = 1;
        }

        transform.position = Vector3.Lerp(startPosition, targetPosition, fractionOfJourney);

        if (transform.position == targetPosition)
        {
            startTime = Time.time;
            startPosition = transform.position;
            Vector3 Offset = Random.insideUnitSphere;
            Offset.z = Offset.z / 2;
            targetPosition = center + Offset * radius;
            journeyLength = Vector3.Distance(transform.position, targetPosition);
        }

        transform.rotation *= Quaternion.Euler(rotateOffset.x * Time.deltaTime, rotateOffset.y * Time.deltaTime, rotateOffset.z * Time.deltaTime); ;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "bullet")
        {
            Debug.Log("Bullet Label:" + other.gameObject.GetComponent<Bullet_Mngr>().GetLabel() + "Obj Label:" + label);
            if (other.gameObject.GetComponent<Bullet_Mngr>().GetLabel() == label)
            {
                Destroy(gameObject);
            }
            
            // Destroy(other.gameObject);
        }
    }
}
