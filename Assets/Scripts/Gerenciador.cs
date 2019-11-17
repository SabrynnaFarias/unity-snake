using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Realtime;
using Photon.Pun;

public class Gerenciador : MonoBehaviour
{
    void Start()
    {
        Vector3 pos = new Vector3(
            PhotonNetwork.IsMasterClient ? -8f : 8f,
            0.76f,
            0f
        );

        PhotonNetwork.Instantiate("Jogador", pos, Quaternion.identity);

        if (PhotonNetwork.IsMasterClient)
        {
            PhotonNetwork.InstantiateSceneObject(
                "Bola", new Vector3(0f, 0.76f, 0f), Quaternion.identity
            );
        }
    }
}