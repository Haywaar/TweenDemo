using DG.Tweening;
using UnityEngine;

public class WaveMovementScript : MonoBehaviour
{
    // Объект 1, к которому мы едем
    public GameObject targetGameObject1;
    
    // Объект 2, к которому мы едем
    public GameObject targetGameObject2;
    
    // Объект 3, к которому мы едем
    public GameObject targetGameObject3;
    
    // Старт вызывается один раз перед первым кадром Update
    void Start()
    {
        // Создаем и заполняем массив точек, по которым пройдет наш объект
        var waypoints = new Vector3[3];
        waypoints[0] = targetGameObject1.transform.position;
        waypoints[1] = targetGameObject2.transform.position;
        waypoints[2] = targetGameObject3.transform.position;

        //tween - команда на движение
        var tween = transform.DOPath(waypoints, 3.0f, PathType.Linear);
        // Так мы говорим команде tween 100 раз повториться. Работает именно с твинами, циклы работают по другому
        tween.SetLoops(100);
    }
   
}
