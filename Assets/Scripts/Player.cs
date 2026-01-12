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
        
        Vector2 movement = new Vector2(movementX, movementY);

        transform.Translate(movement * _speed * Time.deltaTime);

        // The SPACE key plants a seed, which:
        // Checks to see if the player has any seeds left.
        // If they do, it performs actions 3 - 5; otherwise, nothing happens.
        // Makes a plant appear at the player’s location.
        // Decreases the number of seeds the player has left,
        // Increases the number of seeds the player has planted

        //planting seed. instantiating SPACE key plants a seed, which: 
        // needs to have amount of seeds
        // Checks to see if the player has any seeds left. If they do, it performs actions 3-5; otherwise, nothing happens.
    }

    public void PlantSeed ()
    {
        //having a plant to call from 
        // Makes a plant appear at the player’s location.
        //
    }
}
