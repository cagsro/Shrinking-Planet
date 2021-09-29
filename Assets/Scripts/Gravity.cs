using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{

    public GameObject Planet;
    public float gravity=1;
    bool OnGround = false;
    float distanceToGround;
    Vector3 GroundNormal;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit= new RaycastHit();
        if (Physics.Raycast(transform.position,-transform.up,out hit,10))
        {
            distanceToGround = hit.distance;
            GroundNormal= hit.normal;

            if (distanceToGround <=0.1f)
            {
                OnGround=true;
            }
            else
            {
                OnGround=false;
            }
        }
        Vector3 gravDirection = (transform.position - Planet.transform.position).normalized;
         if(OnGround==false)
         {
             rb.AddForce(gravDirection*-gravity);

         }
         Quaternion toRotation = Quaternion.FromToRotation(transform.up, GroundNormal)*transform.rotation;
         transform.rotation = toRotation;
    }
}
