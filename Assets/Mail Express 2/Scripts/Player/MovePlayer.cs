using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class MovePlayer : MonoBehaviour {

    [SerializeField] private float      speed = 10.0F;
    [SerializeField] private float      speedPlayer = 10.0F;

    void Update()
    {
        transform.Translate(0, 0, Time.deltaTime * speedPlayer);
        transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, 0);
    }
}
