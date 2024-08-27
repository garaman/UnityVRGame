using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MonsterManager : MonoBehaviour
{
   private static MonsterManager instance;
   public static MonsterManager Instance
   {
        get
        {
            if(instance == null)
            {
                instance = GameObject.FindObjectOfType<MonsterManager>();
            }
            return instance;
        }
   }

    public UnityEvent<Monster> OnSpawn, OnDestroy;
    private List<Monster> monsters = new List<Monster>();

    private void Awake()
    {
        instance = this;
    }

    public void OnSpawned(Monster monster)
    {
        monsters.Add(monster);
        OnSpawn?.Invoke(monster);
    }

    public void OnDestroyed(Monster monster)
    {
        if( monsters.Remove(monster) )
        {
            OnDestroy?.Invoke(monster);
        }
    }

    public void DestroyAll()
    {
        while (monsters.Count > 0)
        {
            monsters[0].Destroy();
        }
    }
}
