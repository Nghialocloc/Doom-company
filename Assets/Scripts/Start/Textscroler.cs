using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Textscroler : MonoBehaviour
{
    [SerializeField]
    private float scrollSpeed = 20f;

    [SerializeField]
    private GameObject intro;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(intro.transform.up * scrollSpeed * Time.deltaTime);
    }
}
