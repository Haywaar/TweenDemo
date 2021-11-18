using DG.Tweening;
using UnityEngine;

public class RotationScript : MonoBehaviour
{
    void Start()
    {
        //tween - команда. transform.DORotate - вращает объект на 360 градусов за 3.5 секунд 
        var tween = transform.DORotate(new Vector3(0, 360, 0), 3.5f, RotateMode.FastBeyond360);
        tween.onComplete += () => transform.DORestart();
    }
}
