using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMeleeAttack : MonoBehaviour
{
    [SerializeField]
    private GameObject _swordZonePrefab;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Instantiate(_swordZonePrefab, gameObject.transform);
            _swordZonePrefab.transform.position = new Vector2(1,0);

        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            GameObject player = GameObject.FindWithTag("Player");
            
            // On veut vérifier la dirction du joueur qui est dans le fichier PlayerController
            if (PlayerController.direction == "right")
            {


                //PlayerController._rigBod.AddForce(Vector2.right);
            }
            else if(PlayerController.direction == "left")
            {
                //   player.GetComponent<PlayerController>().transform.position = new Vector2(-5, 2);

                //PlayerController._rigBod.AddForce(Vector2.left);
            }
        }
    }
}

