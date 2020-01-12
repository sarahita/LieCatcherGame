# LieCatcher
Repository for the LieCatcher game, written in Unity.

## Server-side requirements

Everything lies in `username@cheshire.cs.columbia.edu:/var/www`, which will be referred to as `~`

### Audio

1. Ensure the directory structure in `~/sorted_wave_segments` is correct
2. If audio is missing/incorrect, run `insert-audio.py`


## Setting up locally

### Cloning the Game

1. Clone the git repo
2. Open in Unity

### Building the Game

1. In the Unity Console, press `Files -> Build Settings`.
2. Set the platform as `WebGL`.
3. In `Player Settings -> Other Settings`, ensure API Compatability Level is `.NET 2.0`.
4. Uncheck `Development Build`.
5. Build.

## Running on a Server

### Move the game file to the server

1. Find the directory where the WebGL game is saved in
2. scp this directory to `username@cheshire.cs.columbia.edu:/var/www/webgl-game`
3. Game can be accessed at https://cheshire.cs.columbia.edu/webgl-game/
# LieCatcherGame
# LieCatcherGame
