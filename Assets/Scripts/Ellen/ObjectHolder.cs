using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ObjectHolder : MonoBehaviour
{
    public event EventHandler onKeysChanged;
    private List<Key.KeyType> keylist;

    //Returns the key list when GetKeyList is called
    public List<Key.KeyType> GetKeyList()
    {
        return keylist;
    }

    //Gets new key type
    private void Awake()
    {
        keylist = new List<Key.KeyType>();
    }

    //Used when a key is added to the object holder
    public void addKey(Key.KeyType keyType)
    {
        keylist.Add(keyType);
        onKeysChanged?.Invoke(this, EventArgs.Empty);
    }

    //Used when a key is used to open a door
    public void removeKey(Key.KeyType keyType)
    {
        keylist.Remove(keyType);
        onKeysChanged?.Invoke(this, EventArgs.Empty);
    }

    //Checks the key type
    public bool ContainsKey(Key.KeyType keyType)
    {
        return keylist.Contains(keyType);
    }

    //Controls the adding and removing keys when a key is collected or used to open a door
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Key key = collision.GetComponent<Key>();

        if(key != null)
        {
            addKey(key.GetKeyType());
            Destroy(key.gameObject);
        }

        Door keyDoor = collision.GetComponent<Door>();
        if (keyDoor != null)
        {
            if (ContainsKey(keyDoor.GetKeyType()))
            {
                //HoldingKeyForDoor
                keyDoor.Opendoor();
                removeKey(keyDoor.GetKeyType());
            }
        }
    }
}
