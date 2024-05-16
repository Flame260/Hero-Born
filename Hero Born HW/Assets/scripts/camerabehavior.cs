using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerabehavior : MonoBehaviour
{
    public Vector3 CamOffset = new Vector3(0f,1.2f,-2.6f);
    // Start is called before the first frame update
    private Transform _target;
    void Start()
    {
        _target = GameObject.Find("player").transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        this.transform.position = _target.TransformPoint(CamOffset);

        this.transform.LookAt(_target);
    }
}
