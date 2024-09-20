using UnityEngine;
using Cinemachine;

public class ZoomController : MonoBehaviour
{
    public CinemachineVirtualCamera virtualCamera;
    public float zoomSpeed = 10f;
    public float minZoom = 20f;
    public float maxZoom = 60f;

    void Update()
    {
        // Usa a rolagem do mouse para controlar o zoom
        float zoomChange = Input.GetAxis("Mouse ScrollWheel") * zoomSpeed;
        virtualCamera.m_Lens.FieldOfView = Mathf.Clamp(virtualCamera.m_Lens.FieldOfView - zoomChange, minZoom, maxZoom);
    }
}
