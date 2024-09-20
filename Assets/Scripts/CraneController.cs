using UnityEngine;
using Cinemachine;

public class CraneController : MonoBehaviour
{
    public CinemachineVirtualCamera virtualCamera;
    public float craneMoveSpeed = 2f;
    public float craneHeightSpeed = 2f;

    void Update()
    {
        // Controla o movimento horizontal (eixo X) com teclas A/D
        float horizontalMove = Input.GetAxis("Horizontal");
        transform.position += new Vector3(horizontalMove * craneMoveSpeed * Time.deltaTime, 0, 0);

        // Controla o movimento vertical (eixo Y) com teclas W/S
        float verticalMove = Input.GetAxis("Vertical");
        transform.position += new Vector3(0, verticalMove * craneHeightSpeed * Time.deltaTime, 0);
    }
}