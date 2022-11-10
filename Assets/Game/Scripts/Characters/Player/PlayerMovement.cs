using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController m_characterController;

    private float m_horizontal = 0f;
    private float m_vertical = 0f;

    private Vector3 m_playerMovement;

    [SerializeField] private float playerSpeed = .5f;

    private void Start()
    {
        m_characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        m_horizontal = Input.GetAxis("Horizontal");
        m_vertical = Input.GetAxis("Vertical");

        m_playerMovement = new Vector3(m_horizontal, 0f, m_vertical) * playerSpeed * Time.deltaTime;

        m_characterController.Move(m_playerMovement);
    }
}
