using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    [SerializeField] private KeyType keytype;
    //2 key states that are used with the key UI , as well as the Door within the level
   public enum KeyType
    {
        Key1,
        Key2,
    }

    public KeyType GetKeyType()
    {
        return keytype;
    }

    
}
