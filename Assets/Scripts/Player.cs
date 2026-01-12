using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;
using static Unity.Burst.Intrinsics.X86;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    private void Start ()
    {
        
    }

    private void Update()
    {
        //sprite movement with WASD and arrow keys
        float movementX = Input.GetAxisRaw("Horizontal");
        float movementY = Input.GetAxisRaw("Vertical");
        
        UnityEngine.Vector2 movement = new UnityEngine.Vector2(movementX, movementY);

        transform.Translate(movement * _speed * Time.deltaTime);

        // instantiating. The SPACE key plants a seed, which:
        if (Input.GetKey(KeyCode.Space))
        {
            PlantSeed();
        }
        

        // Checks to see if the player has any seeds left.
        // If they do, it performs actions 3 - 5; otherwise, nothing happens.
        // Makes a plant appear at the player’s location.
        // Decreases the number of seeds the player has left,

    
    }

    public void PlantSeed ()
    {
        Instantiate(
            _plantPrefab,
            _playerTransform
            );
    }
}
