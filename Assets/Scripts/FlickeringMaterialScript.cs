using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using DG.Tweening;
using UnityEngine;

public class FlickeringMaterialScript : MonoBehaviour
{
    // Материал, который мы будем красить
    public Material material;
    void Start()
    { 
        // Sequence - последовательность команд на движение
        var sequence = DOTween.Sequence();
        // Добавляем команду - перекрасить материал в синий цвет за 0.3 секунды
        sequence.Append(material.DOColor(Color.blue, 0.3f));
        // Добавляем команду - перекрасить материал в белый цвет за 0.3 секунды
        sequence.Append(material.DOColor(Color.white, 0.3f));
        // Добавляем команду - перекрасить материал в красный цвет за 0.3 секунды
        sequence.Append(material.DOColor(Color.red, 0.3f));
      
        // Перезапускаем всю последовательность при завершении 
        sequence.onComplete += () =>
        {
            sequence.Restart();
        };
    }
}
