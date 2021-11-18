using DG.Tweening;
using UnityEngine;

public class DirectMovementScript : MonoBehaviour
{
    // Объект, к которому мы едем
    public GameObject targetGameObject;

    // Поведение полёта
    public DG.Tweening.Ease Ease;

    // Старт вызывается один раз перед первым кадром Update
    void Start()
    {
        // tween - команда. В неё помещаем метод transfor.DOMove
        // В transform.DOMove мы двигаемся к цели targetGameObject.transform.position за 3.0 секунды
        var tween = transform.DOMove(targetGameObject.transform.position, 3.0f, false);
        // Траэктория выполнения движения(в данном примере кубики по разному ускоряются и по разному тормозят)
        tween.SetEase(Ease);
        // При завершении команды она запускается заново
        tween.onComplete += () => { tween.Restart(); };
    }
}
