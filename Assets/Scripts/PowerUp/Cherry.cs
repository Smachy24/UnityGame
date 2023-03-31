using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cherry : MonoBehaviour
{
    [SerializeField]
    private GameObject _corePlayer;

    [SerializeField]
    private GameObject childMage;
    [SerializeField]
    private GameObject childWarrior;

    [SerializeField]
    private GameObject guerrierPrefabToInstantiate;
    [SerializeField]
    private GameObject magePrefabToInstantiate;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            //Instantiate();

            //if(switcher.Mage.gameObject.activeSelf)

            //if(childMage.activeInHierarchy)
            //{
            //    Instantiate(magePrefabToInstantiate, gameObject.transform);
            //}
            //if (childWarrior.activeInHierarchy)
            //{
            //    Instantiate(guerrierPrefabToInstantiate, gameObject.transform);
            //}

            Instantiate(magePrefabToInstantiate, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
