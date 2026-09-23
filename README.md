# Pedro the Penguin

A 2D endless runner set in the Arctic, starring Pedro the Penguin. Dodge ice spikes, duck under blocks, and see how far you can run — controlled entirely by clapping, using an Arduino clap sensor as a custom controller.

## Gameplay

Guide Pedro across an endless, ever scrolling icy landscape. Jump over ice spikes and duck under overhanging blocks to survive as long as possible. The twist: there's no keyboard or gamepad — you play by clapping, detected through a custom Arduino clap sensor controller.

- **Genre:** 2D endless runner
- **Setting:** The Arctic
- **Controls:** Clap to jump / duck, via a custom Arduino clap sensor
- **Goal:** Survive as long as possible, dodging obstacles as the game speeds up

## Controller

This game is designed to be played with a custom Arduino-based clap sensor rather than a keyboard or gamepad. The sensor detects claps and sends input to the game to trigger Pedro's jump/duck actions.

## Music

All music was composed by the developer.

## Built With

- [Unity](https://unity.com/) (2D)
- Arduino (clap sensor controller)

## Getting Started

### Play
1. Clone the repo and open the project in Unity.
2. Connect and set up the Arduino clap sensor controller (see hardware setup below).
3. Open the main scene and press Play in the Unity Editor.
4. Clap to jump over ice spikes and duck under blocks — survive as long as you can!

> Note: the game currently only runs through the Unity Editor — it hasn't been built into a standalone executable.

### Hardware Setup (Arduino Clap Sensor)
1. Wire up the clap/sound sensor to your Arduino board.
2. Flash the Arduino with the provided sketch (see the Arduino folder in this repo, if included).
3. Connect the Arduino to your PC via USB before launching the game.

### Build from source
1. Clone the repo:
   ```bash
   git clone <repo-url>
   ```
2. Open the project in Unity (2D template).
3. Open the main scene and press Play to test, or build for PC via Build Settings.

## Project Status

Made for a class project.

## Author

**Luke Cummins**
GitHub: [@luke-cummins72](https://github.com/luke-cummins72)
