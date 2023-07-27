using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.UI;

public class ResetPlane : MonoBehaviour
{
    ARSession session = new ARSession();

    public void ResetARSession()
    {
        session.Reset();
        
    }
}


