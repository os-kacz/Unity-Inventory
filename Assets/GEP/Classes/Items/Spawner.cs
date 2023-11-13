using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject newItem;
    public ItemTemplate itemValues;
    int IDnumber = 1;
    // Start is called before the first frame update
    void Start()
    {
        spawnEntity();
    }

    // Update is called once per frame
    void spawnEntity()
    {
        GameObject currentItem = Instantiate(newItem, new Vector3(0.4f,2f,2.3f), Quaternion.identity);
        currentItem.name = itemValues.title;
    }
}
