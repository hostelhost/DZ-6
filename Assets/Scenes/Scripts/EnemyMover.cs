using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private float _speed;

    private bool _direction;
    private SpriteRenderer _spriteRenderer;

    private void Start()
    {
        _enemy = GetComponent<Enemy>();
        _spriteRenderer = _enemy.GetComponent<SpriteRenderer>();
        _speed = 3.0f;
    }

    private void Update()
    {
        if (_spriteRenderer.flipX)
            _enemy.transform.Translate(Vector2.left * _speed * Time.deltaTime);
        else
            _enemy.transform.Translate(Vector2.right * _speed * Time.deltaTime);
    }
}
