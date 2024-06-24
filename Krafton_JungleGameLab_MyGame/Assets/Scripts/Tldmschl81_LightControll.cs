using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tldmschl81_LightControll : MonoBehaviour
{
    float theta, angleY;

    void Update()
    {
        Vector3 worldMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 dir = worldMousePos - transform.position;
        if (dir.x > 0)
        {// right
            angleY = 90f;
            theta = Vector2.Angle(Vector2.right, dir);
            transform.localPosition = new Vector3(-1.25f, 0, 1.25f);

        }
        else
        {// left
            angleY = -90f;
            theta = Vector2.Angle(Vector2.left, dir);
            transform.localPosition = new Vector3(1.25f, 0, 1.25f);
        }

        theta = Mathf.Clamp(theta, 0, 35);
        if (dir.y < 0)
        {
            transform.rotation = Quaternion.Euler(theta, angleY, 0);
        }
        else
        {
            transform.rotation = Quaternion.Euler(-theta, angleY, 0);
        }
    }
}
