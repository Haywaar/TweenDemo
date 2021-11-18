using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class SequencialMoveScript : MonoBehaviour
{
    public Transform target1;
    public Transform target2;

    void Start()
    {
        // Команда 1 - двигаемся к цели target1
        var tween1 = transform.DOMove(target1.position, 3.0f, false);
        // Команда 2 - двигаемся к цели target2
        var tween2 = transform.DOMove(target2.position, 3.0f, false);

        // Sequence - последовательность команд на движение
        var sequence = DOTween.Sequence();
        
        // В последовательность помещаем команду 1
        sequence.Append(tween1);
        // После команды 1 ждём 1.5 секунды
        sequence.AppendInterval(1.5f);
        // В последовательность помещаем команду 2
        sequence.Append(tween2);
        // После команды 2 ждём 1.5 секунды
        sequence.AppendInterval(1.5f);

        // При достижении конца последовательности команд -> перезапускаем последовательность
        sequence.onComplete += () =>
        {
            sequence.Restart();
        };
    }
}
