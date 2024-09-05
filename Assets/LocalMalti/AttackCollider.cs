using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackCollider : MonoBehaviour
{
    [SerializeField]
    float _forcePower = 5;
    [SerializeField]
    int _damage = 100;
    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.root.gameObject.TryGetComponent<Rigidbody>(out Rigidbody rb))
        {
            rb.velocity = Vector3.zero;
            rb.AddForce(Vector3.up * _forcePower,ForceMode.Impulse);
        }
        if(other.transform.root.gameObject.TryGetComponent<PlayerStatus>(out PlayerStatus ps))
        {
            ps.Damage(_damage);
        }
    }
}
