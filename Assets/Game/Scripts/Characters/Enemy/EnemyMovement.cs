using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float enemySpeed;

    private void Update()
    {
        Vector3 localPosition = PlayerInstance.Instance.position - transform.position;
        transform.Translate(localPosition.x * Time.deltaTime * enemySpeed,
            0f,
            localPosition.z * Time.deltaTime * enemySpeed);
    }
}
