using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowRotate : MonoBehaviour
{
    [SerializeField] private float speed = 5;
    
    void Update()
    {
        transform.Rotate(Vector3.up * speed * Time.deltaTime);
    }
}
