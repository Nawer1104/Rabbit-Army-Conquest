using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    private Animator anim;

    public bool isBlue;

    public GameObject vfxBlue;

    private void Awake()
    {
        anim = GetComponent<Animator>();

        isBlue = false;
    }

    public void SetTriggerBlue()
    {
        anim.SetTrigger("Blue");

        GameObject vfx = Instantiate(vfxBlue, transform.position, Quaternion.identity) as GameObject;

        Destroy(vfx, 1f);

        isBlue = true;
    }
}
