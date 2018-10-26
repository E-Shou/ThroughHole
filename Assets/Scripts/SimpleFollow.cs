using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleFollow : MonoBehaviour {
    Vector3 diff;

    public GameObject target;
    public float speedZ;

    // Use this for initialization
    void Start () {
    }

    // Update is called once per frame
    void LateUpdate () {
        target.transform.localPosition += new Vector3(0f, 0f, speedZ * Time.deltaTime);
    }
}
