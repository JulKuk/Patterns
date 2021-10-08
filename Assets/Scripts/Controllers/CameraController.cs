using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform _entity;
    private Vector3 _offset = new Vector3(0,1,-5);

    void Update()
    {
        transform.position = _entity.position + _offset;
    }
}
