using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    private Transform target;
    [SerializeField]
    private float smoothSpeed = 5f;
    Vector3 offset;


    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - target.position; // Ball to Cam dis
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // CameraWork Lateuptdate...physics :FixedUptdate

        Vector3 targetCampos = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, targetCampos, smoothSpeed * Time.deltaTime);
        transform.LookAt(target);

    }
}
