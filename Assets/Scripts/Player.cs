using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;
using static Unity.Burst.Intrinsics.X86;
using static UnityEditor.Experimental.GraphView.GraphView;

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
        _numSeedsLeft = _numSeeds;
        _numSeedsPlanted = 0;
    }

    private void Update()
    {
        //sprite movement with WASD and arrow keys
        float movementX = Input.GetAxisRaw("Horizontal");
        float movementY = Input.GetAxisRaw("Vertical");
        
        UnityEngine.Vector2 movement = new UnityEngine.Vector2(movementX, movementY);

        transform.Translate(movement * _speed * Time.deltaTime);

        // The SPACE key plants a seed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlantSeed();
        }
        

        

    
    }

    public void PlantSeed ()
    {
        // Checks to see if the player has any seeds left.
        if (_numSeedsLeft <= 0)
            return;

         // Makes a plant appear at the player’s location.
        Instantiate(_plantPrefab, transform.position,UnityEngine.Quaternion.identity);

        // Decreases the number of seeds the player has left
        // Increases the number of seeds the player has planted
        _numSeedsLeft--;
        _numSeedsPlanted++;
        
    }
}
