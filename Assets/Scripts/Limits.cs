using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limits : MonoBehaviour
{
    public Camera mainCamera;
    Vector2 screenBounds;
    float objectWidth;
    float objectHeight; 

    void Start()
    {
        screenBounds = mainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, mainCamera.transform.position.z));
        objectWidth = transform.GetComponent<SpriteRenderer>().bounds.extents.x;
        objectHeight = transform.GetComponent<SpriteRenderer>().bounds.extents.y;
    }

    void LateUpdate()
    {
        Vector3 viewPositon = transform.position;
        viewPositon.x = Mathf.Clamp(viewPositon.x, screenBounds.x * -1 + objectWidth, screenBounds.x - objectWidth);
        viewPositon.y = Mathf.Clamp(viewPositon.y, screenBounds.y * -1 + objectHeight, screenBounds.y - objectHeight);
        transform.position = viewPositon;
    }
}
