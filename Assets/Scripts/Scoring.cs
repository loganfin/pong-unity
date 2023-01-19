using UnityEngine;
using UnityEngine.EventSystems;

public class Scoring : MonoBehaviour
{
    public Ball ball;
    public GameObject score;
    private EdgeCollider2D edge;

    public EventTrigger.TriggerEvent scoreTrigger;

    public void Start()
    {
        edge = GetComponent<EdgeCollider2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        ball = collision.gameObject.GetComponent<Ball>();

        if (ball != null) {
            BaseEventData eventData = new BaseEventData(EventSystem.current);
            this.scoreTrigger.Invoke(eventData);
        }
    }
}
