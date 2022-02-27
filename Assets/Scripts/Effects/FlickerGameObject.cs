using System.Collections;
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
        StartCoroutine(FlashCoroutine());
    }

    IEnumerator FlashCoroutine()
    {
        flickerObject.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        flickerObject.SetActive(false);
    }
}
