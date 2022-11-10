using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TargetType
{
    Mouse,
    Player
};
public class CharacterAim : MonoBehaviour
{
    [SerializeField] private TargetType targetType = TargetType.Player;

    [SerializeField] private LayerMask layermask;
    [SerializeField] private float yHeight = 0f;
    private Camera mainCamera;

    private void Awake()
    {
        if (targetType == TargetType.Mouse)
        {
            mainCamera = Camera.main;
        }
    }

    private void Update()
    {
        if (targetType == TargetType.Mouse)
        {
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hit, float.MaxValue, layermask))
            {
                Vector3 targetPosition = new Vector3(hit.point.x, yHeight, hit.point.z);

                Quaternion rotation = Quaternion.LookRotation(targetPosition - transform.position);

                transform.rotation = Quaternion.Lerp(transform.rotation, rotation, Time.deltaTime * 10f);
            }
        }

        if(targetType == TargetType.Player)
        {
            Vector3 targetPosition = new Vector3(PlayerInstance.Instance.position.x, transform.position.y, PlayerInstance.Instance.position.z);

            Quaternion rotation = Quaternion.LookRotation(targetPosition - transform.position);

            transform.rotation = Quaternion.Lerp(transform.rotation, rotation, Time.deltaTime * 10f);
        }
    }
}
