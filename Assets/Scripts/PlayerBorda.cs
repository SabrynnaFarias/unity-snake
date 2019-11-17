using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Realtime;
using Photon.Pun;

public class PlayerBorda : MonoBehaviour
{
    public ePlayer player;
    public ScoreUI score;
    void OnCollisionEnter(Collision col)
    {
        if (!PhotonNetwork.IsMasterClient)
            return;
        Bola ball = col.gameObject.GetComponent<Bola>();
        if (ball != null)
        {
            ball.transform.position = new Vector3(0f, 1f, 0f);

            if (player == ePlayer.Right) score.scorePlayerLeft++;
            else if (player == ePlayer.Left) score.scorePlayerRight++;
        }
    }
}
