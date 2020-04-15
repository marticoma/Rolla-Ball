using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = startPosition + new Vector3(0, Mathf.Sin(Time.time), 0);
    }
}
