using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField]
    private GameObject player;
    [SerializeField]
    private Vector3 cameraPosition;
    // Start is called before the first frame update
    void Start()
    {
        cameraPosition = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        MoveCamera();
    }

    void MoveCamera()
    {
        transform.position = transform.position - cameraPosition;
    }
}
