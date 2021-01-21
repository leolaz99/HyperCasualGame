using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler
{
    bool canGrow = true;
    List<GameObject> pooledObjects = new List<GameObject>();
    
    
    /// <summary>
    /// Setta se la lista usa un numero specifico di GameObject o può crearli autonomamente
    /// </summary>
    public ObjectPooler(bool canGrow = true)
    {
        this.canGrow = canGrow;
    }
    

    /// <summary>
    /// crea la lista
    /// </summary>
    public List<GameObject> PooledObjects { get { return pooledObjects; } }


    /// <summary>
    /// Instanzia un numero specifico di GameObject e li disattiva
    /// </summary>
    public void Init(GameObject prefab, int pooledAmount)
    {
        for (int i = 0; i < pooledAmount; i++)
        {
            GameObject obj = Spawn(prefab);

            obj.SetActive(false);
        }
    }


    /// <summary>
    /// Attiva il primo GameObject disattivato nella lista, se tutti sono attivi e può crescere ne crea un altro.
    /// </summary>
    public GameObject Instantiate(GameObject prefab)
    {
        foreach (GameObject obj in pooledObjects)
        {
            if (obj.activeInHierarchy == false)
            {
                obj.SetActive(true);
                return obj;
            }
        }

        if (canGrow)
        {
            return Spawn(prefab);
        }

        return null;
    }


    /// <summary>
    /// Attiva il primo GameObject disattivato nella lista, se tutti sono attivi e può crescere ne crea un altro.
    /// </summary>
    public GameObject Instantiate(GameObject prefab, Vector3 position, Quaternion rotation)
    {
        GameObject obj = Instantiate(prefab);

        obj.transform.position = position;
        obj.transform.rotation = rotation;

        return obj;
    }


    /// <summary>
    /// Disattiva gli oggetti nella lista
    /// </summary>
    public void DeactiveAll()
    {
        for (int i = 0; i < pooledObjects.Count; i++)
        {
            pooledObjects[i].SetActive(false);
        }
    }


    GameObject Spawn(GameObject prefab)
    {
        GameObject obj = Object.Instantiate(prefab);
        pooledObjects.Add(obj);

        return obj;
    }
}