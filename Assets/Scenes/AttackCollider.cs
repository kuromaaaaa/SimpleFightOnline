using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackCollider : MonoBehaviour
{
    [SerializeField]
    float _forcePower = 5;
    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.root.gameObject.TryGetComponent<Rigidbody>(out Rigidbody rb))
        {
            rb.AddForce(Vector3.up * _forcePower,ForceMode.Impulse);
        }
    }
}
