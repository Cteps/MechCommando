using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public Player player;
    public enum type { Health = 0, Shield = 1 }
    public type tipo;

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            if (tipo == 0)
            {
                player.healthPacksQt++;
                this.gameObject.SetActive(false);
            }

        }

    }


}
