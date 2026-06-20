/******************************************************************
 * This script is attached to the Main Camera.
 * It is designed to allow the camera to follow the player
 * 
 * Author: Bruce Gustin
 * Date Written: July 8, 2025
 * Version 1.0
 *****************************************************************/

using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    [SerializeField] private Vector3 offset;


    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = playerTransform.position + offset;
    }
}
