using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickerGameObject : MonoBehaviour
{
    private GameObject flickerObject;

    private void Start()
    {
        flickerObject = transform.GetChild(0).gameObject;
    }

    public void Flicker()
    {
        Debug.Log("flickering");
        flickerObject.SetActive(true);
        StartCoroutine(WaitCoroutine());
        flickerObject.SetActive(false);
    }

    IEnumerator WaitCoroutine()
    {
        yield return new WaitForSeconds(0.1f);
    }
}
