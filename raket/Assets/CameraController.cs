using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] Vector3 offset;
    [SerializeField] float smoothingSpeed = 10f;
    
    Transform playerTransform;

        // Start is called before the first frame update
    private void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        Vector3 targetPos = playerTransform.position + offset;

        transform.position = Vector3.Lerp(transform.position, targetPos, Time.deltaTime * smoothingSpeed);

        transform.LookAt(playerTransform);
    }
}
 