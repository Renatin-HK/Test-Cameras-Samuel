using UnityEngine;
using Cinemachine;

public class PanTiltController : MonoBehaviour
{
    public CinemachineVirtualCamera virtualCamera;
    public float panSpeed = 1f;
    public float tiltSpeed = 1f;

    private CinemachineComposer composer;

    void Start()
    {
        // Obtém o CinemachineComposer para controlar a rotação
        composer = virtualCamera.GetCinemachineComponent<CinemachineComposer>();
    }

    void Update()
    {
        // Controla o Pan (horizontal) com as setas ou teclas A/D
        float panInput = Input.GetAxis("Horizontal");
        composer.m_TrackedObjectOffset.x += panInput * panSpeed * Time.deltaTime;

        // Controla o Tilt (vertical) com as setas ou teclas W/S
        float tiltInput = Input.GetAxis("Vertical");
        composer.m_TrackedObjectOffset.y += tiltInput * tiltSpeed * Time.deltaTime;
    }
}