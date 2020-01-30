using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardRigiControl : MonoBehaviour
{
    private Rigidbody rgBody;

    private void Start() {
        rgBody = GetComponent<Rigidbody>();
    }

    private void OnCollisionStay(Collision other) {
        rgBody.isKinematic = true;
    }

}
