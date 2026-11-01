using UnityEngine;
using UnityEngine.InputSystem;
public class MissileSpawner : MonoBehaviour
{
    
    public GameObject missilePrefab;
    public Rigidbody2D rb; 
    public Transform spawnPoint;
    public float missileSpeed = 3;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            FireMissile();
        }
    }
    
    
    
    private void FireMissile()
    {
        GameObject newMissile = Instantiate(missilePrefab, spawnPoint.position, spawnPoint.rotation);
        
        Rigidbody2D rb = newMissile.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.linearVelocity = spawnPoint.right * missileSpeed;
        }

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
