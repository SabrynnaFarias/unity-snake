using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Realtime;
using Photon.Pun;

public enum ePlayer
{
    Left,
    Right
}

public class Jogador : MonoBehaviour
{
    public float speed = 15f;
    public ePlayer player;
    public PhotonView view;

    private void Awake()
    {
        if (transform.position.x < 0) 
        {
            player = ePlayer.Left;
        } 

        else
        {
            player = ePlayer.Right;
        }

        view = GetComponent<PhotonView>();
    }

    void Update()
    {
        if (!view.IsMine)
            return;
        float inputSpeed = 0f;
        if (player == ePlayer.Left)
        {
            inputSpeed = Input.GetAxisRaw("Jogador Esquerda");
        }
        else if (player == ePlayer.Right)
        {
            inputSpeed = Input.GetAxisRaw("Jogador Direita");
        }

        transform.position += new Vector3(0f, 0f, inputSpeed * speed * Time.deltaTime);
    }
}
