using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject lookAtMe;
    public float rotateSpeed = 5000f;
    public float scrollSpeed = 5000;
    Vector2 clickPoint;
    float dragSpeed = 500.0f;

    private void Update()
    {
        CameraMoving();
    }

    private void CameraMoving()
    {

        if (Input.GetMouseButtonDown(0)) clickPoint = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

        if (Input.GetMouseButton(0))
        {
            lookAtMe.transform.SetParent(this.transform);

            Vector3 position
                = Camera.main.ScreenToViewportPoint(clickPoint - (Vector2)Input.mousePosition);

            position.z = position.y;
            //position.y = .0f;

            Vector3 move = position * (Time.deltaTime * dragSpeed);

            float y = transform.position.y;

            transform.Translate(move);
            transform.position
                = new Vector3(transform.position.x, y, transform.position.z);
            
        }
        else
        {
            lookAtMe.transform.SetParent(null);

            float scroollWheel = Input.GetAxis("Mouse ScrollWheel");

            Vector3 cameraDirection = this.transform.localRotation * Vector3.forward;

            this.transform.position += cameraDirection * scroollWheel * scrollSpeed;
        }
    }
}
