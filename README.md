# MG7
## Devlog
My TreeOfBirds script first begins with 3 member variables, all exposed to the editor via SerializeField: _sparrows (an arrow containing Bird Components of all the existing sparrows bar Sparrow_Start), _interactDist (contains a float value that represents the maximum distance between a given bird in _sparrows and the player which the birds in the tree will begin activating at), and _playerTrans (the Transform Component representative of the player, this being set to the Transform Component of the Colobus rig.)

After this, since the specifications for TreeOfBirds mentioned that the main behavior of this class requires a method to be run every frame, TreeOfBirds was designated to inherit from MonoBehaviour and the Update() method was created.

From here, Update() runs a foreach loop every frame, essentially iterating through each element (therefore, each Bird Component of all sparrows except for Sparrow_Start) of the _sparrows array. Each iteration then checks if the GameObject that the Bird Component being referenced is attached to (this would be a sparrow) is at most the value of _interactDist away from the position of the player. This is done by feeding the position of the GameObject that the current Bird Component is attached to (Vector3 value) and the position of the player as given by the Transform Component _playerTrans (Vector3 value) into Vector3's Distance() method and checking if the resulting float value is less than or equal to _interactDist. If this check returns true, then the current Bird Component's associated GameObject is enabled via the SetActive() method, and the process is repeated for the next iteration until _sparrows has been iterated through.

Essentially, this allows every sparrow GameObject (once again, excluding Sparrow_Start) to check if it is close enough to the player every frame, at which point it will activate the said sparrow GameObject and allow it to perform its own behaviors as specified in Bird.cs.

## Open-Source Assets
- [Forest Nature Pack](https://kaylousberg.itch.io/kaykit-forest) - environment 3D models
- [Quirky Series](https://assetstore.unity.com/packages/3d/characters/animals/quirky-series-free-animals-pack-178235) - animal 3D models
