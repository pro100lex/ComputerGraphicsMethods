using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField] private float _impulseX;
    [SerializeField] private float _impulseY;
    
    private Rigidbody2D _rb2d;

    private void Awake()
    {
        _rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("tap");
            _rb2d.AddForce(new Vector2(_impulseX, _impulseY), ForceMode2D.Impulse);
        }
    }
}
