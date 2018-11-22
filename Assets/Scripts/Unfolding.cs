using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unfolding : MonoBehaviour
{
    [SerializeField] Transform Axis;
   
	// Use this for initialization
	void Start ()
    {
        var v0 = new Vector3(36.37f, 2, 21);
      
        var v1 = new Vector3(-36.37f, 2, 21);
        var a = Instantiate(Axis, transform);
        a.localPosition = (v0 + v1) / 2;
        a.localRotation = Quaternion.LookRotation(a.up,v1-v0);
        a.localScale = new Vector3(1f, (v1 - v0).magnitude / 2, 1f);
        a.name = "RotatingAxis";
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
