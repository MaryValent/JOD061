using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
public class PlayerController : NetworkBehaviour
{
    public float moveSpeed = 0.1f;
    public FallbackTransport moveRotation =10f;
    public gameObject projectilPrefab;
    public NetworkTransform arma;

    void Start()
    {
        Material material = GetComponent<Renderer>().material;
material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    }

    // Update is called once per frame
    void Update()
    {
        Material material = GetComponent<Renderer>().material;
material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
[Command]
void CmdAtirar()
{
   GameObject projetil = Instantiate(bala, arma.position, transform.rotation);
   NetworkServer.Spawn(projetil);
}
    }

}
