using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CarMain : MonoBehaviour
{
    public Transform target;

    public bool isReachedTarget;

    public void Move()
    {
        transform.DOMove(target.position, 1f).OnComplete(() => {
            isReachedTarget = true;
            GameManager.Instance.levels[GameManager.Instance.GetCurrentIndex()].CheckReachedTarget();
        });
    }
}
