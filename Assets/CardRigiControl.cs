using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardRigiControl : MonoBehaviour
{
    private Rigidbody rigidbody;

    private void Start() {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void OnCollisionStay(Collision other) {
        rigidbody.isKinematic = true;
    }

}
