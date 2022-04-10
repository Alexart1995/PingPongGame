# PingPongGame
Small 2D game. <br>
Play Ping Pong <br>
Play with your friend! <br>

<img src="https://github.com/Alexart1995/PingPongGame/blob/main/GameField.png" width="400" height="250">
<img src="https://github.com/Alexart1995/PingPongGame/blob/main/StartGame.png" width="400" height="250">
<img src="https://github.com/Alexart1995/PingPongGame/blob/main/EndGame.png" width="400" height="250">

## Usage and control
- In Main Menu press `PLAY` to start game
- Control Player 1 with `W` and `S` 
- Control Player 2 with `up` and `down` 
- Play until 5 points
- In End Menu you can go to Main Menu or Retry

## Description of the creation of the game and its elements
### Scene
- Scene created with 2D Box Colliders 
- Ball created with 2D Box Colliders and has properties of RigidBoby 
- Player's rackets created with 2D Box Colliders and has properties of RigidBoby
- Scores and scenes inscreptions implemented with UI
- All events are changing and checking with SceneManagement

### Player and Ball
- Player is moving by changing directions of Vector
- Ball direction and position is implemented by `CollisionDetection.cs` and depends on which side our ball collides
- When our ball collides with a wall music sound is reproduced
