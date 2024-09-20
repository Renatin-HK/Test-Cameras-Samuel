using UnityEngine;
using Cinemachine;
using TMPro;
public class CameraSwitcher : MonoBehaviour
{
    public CinemachineVirtualCamera idleCamera;
    public CinemachineVirtualCamera panTiltCamera;
    public CinemachineVirtualCamera zoomCamera;
    public CinemachineVirtualCamera dollyCamera;
    public CinemachineVirtualCamera craneCamera;
    
    public TextMeshProUGUI cameraText; // Texto que mostra o nome da câmera
    private CinemachineVirtualCamera activeCamera;

    void Start()
    {
        // Definir a câmera inicial (Idle)
        SwitchCamera(idleCamera, "Camera (Idle)");
    }

    void Update()
    {
        // Trocar câmeras com base no input
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SwitchCamera(idleCamera, "Camera (Idle)");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SwitchCamera(panTiltCamera, "Camera (Pan and Tilt)");
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SwitchCamera(zoomCamera, "Camera (Zoom)");
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            SwitchCamera(dollyCamera, "Camera (Dolly)");
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            SwitchCamera(craneCamera, "Camera (Crane)");
        }
    }

    void SwitchCamera(CinemachineVirtualCamera newCamera, string cameraName)
    {
        if (activeCamera != null && activeCamera != newCamera)
        {
            activeCamera.Priority = 0; // Desativa a câmera anterior
        }

        newCamera.Priority = 10; // Ativa a nova câmera
        activeCamera = newCamera;

        // Atualiza o texto na tela
        cameraText.text = cameraName;
    }
}