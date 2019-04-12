using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translate : MonoBehaviour
{
    public Transform player;

    public GameObject portal;

    public void translate()
    {
        player.position = new Vector3(20f, 0f, 0f);
        portal.SetActive(false);
    }
}
