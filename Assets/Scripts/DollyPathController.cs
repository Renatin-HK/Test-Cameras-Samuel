using UnityEngine;
using Cinemachine;

public class DollyPathController : MonoBehaviour
{
    public CinemachineVirtualCamera virtualCamera; // A câmera virtual conectada ao Dolly
    public float dollySpeed = 5f;
    private CinemachineTrackedDolly trackedDolly;

    void Start()
    {
        // Acessa o componente CinemachineTrackedDolly dentro da Virtual Camera
        trackedDolly = virtualCamera.GetCinemachineComponent<CinemachineTrackedDolly>();
    }

    void Update()
    {
        // Controla o valor do Path Position com as teclas A/D ou setas
        float moveInput = Input.GetAxis("Horizontal");
        
        // Atualiza o Path Position (valor entre 0 e 1)
        if (trackedDolly != null)
        {
            trackedDolly.m_PathPosition += moveInput * dollySpeed * Time.deltaTime;
        }
    }
}