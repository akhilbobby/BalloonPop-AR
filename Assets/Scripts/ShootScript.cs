using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ShootScript : MonoBehaviour
{

    public GameObject arCamera;
    public GameObject smoke;
    
    public void Shoot()
    {
        RaycastHit hit;

        //if the raycast hits a virtual object, the result is stores in the "hit" varialble
        if(Physics.Raycast (arCamera.transform.position, arCamera.transform.forward, out hit))
        {
            if(hit.transform.name == "balloon1(Clone)" || hit.transform.name == "balloon2(Clone)" || hit.transform.name == "balloon3(Clone)")
            {
                //destroy the balloon you hit
                Destroy(hit.transform.gameObject);
                Instantiate(smoke, hit.point, Quaternion.LookRotation(hit.normal));

                ScoreManager.instance.AddPoint();

                ARSession session = new ARSession();
                session.Reset();
            }
        }
    }
    
}
