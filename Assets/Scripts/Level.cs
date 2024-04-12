using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    public List<GameObject> gameObjects;

    public CarMain[] mains;

    public void CarGo()
    {
        if (gameObjects.Count <= 0)
        {
            foreach(CarMain car in mains)
            {
                car.Move();
            }
        }
    }

    public void CheckReachedTarget()
    {
        for(int i = 0; i < mains.Length; i ++)
        {
            if (mains[i].isReachedTarget == false)
            {
                return;
            }
        }

        GameManager.Instance.CheckLevelUp();
    }

    public static List<GameObject> GetAllChilds(GameObject Go)
    {
        List<GameObject> list = new List<GameObject>();
        for (int i = 0; i < Go.transform.childCount; i++)
        {
            list.Add(Go.transform.GetChild(i).gameObject);
        }
        return list;
    }
}
