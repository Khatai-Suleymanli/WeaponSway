using System;
using UnityEngine;



public class WeaponSway : MonoBehaviour
{
    public GameObject kub;
    float preciseness = 0.9f;
    [Header("Sway Settings")]
    [SerializeField] private float smooth;
    [SerializeField] private float multiplier;

    private void Update()
    {
        // get mouse input
        float mouseX = Input.GetAxisRaw("Mouse X") * multiplier;
        float mouseY = Input.GetAxisRaw("Mouse Y") * multiplier;

        // calculate target rotation
        Quaternion rotationX = Quaternion.AngleAxis(-mouseY, Vector3.right);
        Quaternion rotationY = Quaternion.AngleAxis(mouseX, Vector3.up);

        Quaternion targetRotation = rotationX * rotationY;

        // rotate 
        transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation, smooth * Time.deltaTime);
    }

    void OnDrawGizmos()
    {
        Vector3 kubPos = kub.transform.position;
        Vector3 playerPos = gameObject.transform.position;
        Vector3 playerLookDir = transform.forward;

        Vector3 playerToObjectDir = (kubPos - playerPos).normalized;

        float lookness = Vector3.Dot(playerLookDir, playerToObjectDir);

        bool isLooking = lookness >= preciseness;

        if (isLooking)
        {
            Destroy(kub);
        }

        Gizmos.color = Color.white;
        Gizmos.DrawLine(playerPos, playerPos + playerToObjectDir);
        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(playerPos, playerPos + playerLookDir);




    }
}
