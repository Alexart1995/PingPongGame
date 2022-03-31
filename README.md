# PingPongGame
Small 2D game from Udemy course. <br>
Play Ping Pong <br>
Play with your friend! <br>

<img src="https://github.com/Alexart1995/PingPongGame/blob/main/EndGame.png" width="400" height="250">
<img src="https://github.com/Alexart1995/PingPongGame/blob/main/GameField.png" width="400" height="250">
<img src="https://github.com/Alexart1995/PingPongGame/blob/main/StartGame.png" width="400" height="250">
## Usage and control
- Press `S` to start moving
- Press `Space` to change direction

## Description of the creation of the game and its elements
### Character
- Character was taken from Unity Asset Store with animations
- Animations were edited with Animator
- Triggers were added for changing animations-
- Moves of player is automatic and increases by increasing score
- Falling of character is checked by Raycaster which is looking down on axis y
### Crystals and Road
- Crystals were taken from Unity Asset Store
- Crystals are destroying by on Function `OnTrigger`
- Road and Crystals are automaticly created by `RoadCreation.cs` from first end of our road
### Game Manager
- Changes Score 
- Saves Highscore that you can beat it later
- Loads scene after you lose
### Music
- Music is added from Unity Asset Store
