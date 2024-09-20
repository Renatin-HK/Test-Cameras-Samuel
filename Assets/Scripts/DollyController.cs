using UnityEngine;
using Cinemachine;

public class DollyController : MonoBehaviour
{
    public CinemachineDollyCart dollyCart;
    public float dollySpeed = 5f;

    void Update()
    {
        // Controla o movimento ao longo da trilha com teclas A/D ou setas
        float moveInput = Input.GetAxis("Horizontal");
        dollyCart.m_Position += moveInput * dollySpeed * Time.deltaTime;
    }
}