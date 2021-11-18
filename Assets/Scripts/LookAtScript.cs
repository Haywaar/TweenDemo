using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class LookAtScript : MonoBehaviour
{
    public Transform target_1;
    public Transform target_2;
    
    // Start is called before the first frame update
    void Start()
    {
        var seq = DOTween.Sequence();
        var tween1 = transform.DOLookAt(target_1.position, 1.2f);
        var tween2 = transform.DOLookAt(target_2.position, 1.2f);

        seq.Append(tween1);
        seq.AppendInterval(2.0f);
        seq.Append(tween2);
        seq.AppendInterval(2.0f);
        seq.SetLoops(100);
        //seq.onComplete += () => seq.Restart();
    }


}
