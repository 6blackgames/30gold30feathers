using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trans : MonoBehaviour
{
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        float move = Input.GetAxis("Vertical");
        float turn = Input.GetAxis("Horizontal");
        anim.SetFloat("vertical", move);
        anim.SetFloat("horizontal", turn);
    }
}