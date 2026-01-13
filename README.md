[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## Devlog
Nicole Yang, She/Her

The plan I wrote in MG1 break-down activity connects to the code I wrote because I had the attributes and actions of the player, the plant, and the UI laid out which helped me write what code was 
needed for each GameObject. I wrote down that the attributes of the player was that it had a number of plant seeds. In the Start method I wrote the code _numSeedsLeft = _numSeeds; with _numSeeds already 
being set to 5. This is so that when the game first starts, the player already starts with 5 seeds. I wrote that the actions the player has is that is can be moved with the WASD keys. 
I wrote this code under the Update method so that the player's movement is updated every frame to ensure smooth movement. I wrote the code float movementX = Input.GetAxisRaw("Horizontal"); 
float movementY = Input.GetAxisRaw("Vertical"); UnityEngine.Vector2 movement = new UnityEngine.Vector2(movementX, movementY); so that if the player presses the WASD keys, they will be able to move. 
Another action the player had was that it can plant seeds when they press the space key. I also wrote this in the Update method with the same logic that the seed being planted 
needs to be updated through every frame. I wrote if (Input.GetKeyDown(KeyCode.Space)){PlantSeed();} so that the seed isn't continuously being planted when the space button is pressed once but rather 
the seed is only planted once when the space button is pressed once. 

I wrote that the Plant GameObject needed to be instantiated from so in the PlantSeed Method I wrote
Instantiate(_plantPrefab, transform.position,UnityEngine.Quaternion.identity); so that plant being instantiated will be spawn at the player's position. I wrote a few additional code so that 
the seeds with the player decreases everytime it is being planted and the seeds planted increases everytime it is being planted.

In my plan, I wrote that the UI's attribute was that it has text that shows the number of seeds remaining and the number of seeds planted. The actions I wrote down is that when the player plants 
a seed, the number of seeds remaining and the number of seeds planted will update. I wrote the following code in the UpdateSeeds method: _remainingText.text = "Seeds remaining: " + seedsLeft; 
_plantedText.text = "Seeds Planted: " + seedsPlanted; to ensure that both text will be updated every time a seed is planted. In the PlantSeed Method, I wrote the code _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
so that the PlantCountUI is referenced and would actually update. 

## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites
