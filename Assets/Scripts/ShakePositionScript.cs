using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class ShakePositionScript : MonoBehaviour
{
    void Start()
    {
        var tween = transform.DOShakePosition(2, 4, 10, 90);
        var seq = DOTween.Sequence();
        seq.Append(tween);
        seq.AppendInterval(2f);
        seq.onComplete += () =>
        {
            seq.Restart();
        };
    }
   
}
