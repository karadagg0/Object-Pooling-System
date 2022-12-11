using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public GameObject hedef;
    public GameObject PrefabKarakter;
    public GameObject SpawnPoint;
    public GameObject VarisNoktasi;
    public List<GameObject> characters;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            foreach (var item in characters)
            {
                if (!item.activeInHierarchy)
                {
                    item.transform.position = SpawnPoint.transform.position;
                    item.SetActive(true);
                    break;
                }
            }
        }
    }
}
}