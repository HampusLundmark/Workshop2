using System;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private float zoomSpeed;

    private Camera cameraObject;
    
    private void Start()
    {
        cameraObject = GetComponent<Camera>();
    }

    private void Update()
    {
        #region Movement
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");
        
        Vector3 moveDifference = new Vector3(xInput, yInput, 0) * moveSpeed * Time.deltaTime;
        transform.position += moveDifference;
        #endregion
        
        #region Zooming
        if (Input.GetKey(KeyCode.UpArrow))
        {
            cameraObject.orthographicSize -= zoomSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            cameraObject.orthographicSize += zoomSpeed * Time.deltaTime;
        }
        cameraObject.orthographicSize = Mathf.Abs(cameraObject.orthographicSize);
        #endregion
    }
}
