# 🎮 Rock-Paper-Scissors-Lizard-Spock (RPSLS) Game

This is a simple console-based game inspired by the classic "Rock-Paper-Scissors" with an added twist! The **Rock-Paper-Scissors-Lizard-Spock (RPSLS)** game extends the traditional game with two more gestures: Lizard and Spock. This was one of my first projects to get hands-on experience with **C#** programming, object-oriented design, and building interactive console applications.

## 📖 Overview

The game allows one or two players to compete in a fun, text-based environment. Players can choose gestures from the classic "Rock-Paper-Scissors" options, as well as "Lizard" and "Spock." The game will compare the gestures and determine the winner based on a set of predefined rules.

### Rules of RPSLS

- Rock crushes Scissors
- Scissors cuts Paper
- Paper covers Rock
- Rock crushes Lizard
- Lizard poisons Spock
- Spock smashes Scissors
- Scissors decapitates Lizard
- Lizard eats Paper
- Paper disproves Spock
- Spock vaporizes Rock

## 🚀 Features

- **Single Player vs. Computer**: Play against a computer opponent with randomly chosen gestures.
- **Two-Player Mode**: Play against a friend in a local multiplayer setting.
- **Dynamic Gameplay**: Players can enter their names, and the game will track scores and determine the winner after a best-of-three series.
- **Reusable Code**: The project showcases the use of object-oriented principles such as classes, inheritance, and polymorphism.

## 🛠️ Technologies Used

- **C#**: The primary programming language used for developing the game.
- **.NET Core**: Used to run the console application.

## 📝 Game Structure

The project consists of several classes that work together to create the game:

- **`Game`**: The main class that handles the game logic, including welcoming the player, choosing the number of players, creating player objects, comparing gestures, displaying the game winner, and running the game loop.
- **`Player`**: The base class for both human and computer players, storing common properties like name, score, and chosen gesture.
- **`HumanPlayer`**: A subclass of `Player` that allows a human player to choose their gesture.
- **`ComputerPlayer`**: A subclass of `Player` that randomly selects a gesture for the computer.

## 🕹️ How to Play

1. **Welcome Message**: The game starts with a welcome message and an explanation of the rules.
2. **Choose Number of Players**: Players are prompted to choose either 1 or 2 players.
3. **Enter Player Names**: Depending on the number of players, users enter the names of one or both players.
4. **Select Gestures**: Players select their gestures (Rock, Paper, Scissors, Lizard, or Spock).
5. **Round Results**: The game compares the gestures and awards points to the winner of each round.
6. **Game Winner**: The game announces the winner once a player reaches 2 points.

---

This project was a great learning experience that helped me understand the basics of C# programming and object-oriented design principles. It was fun to implement the extended rules of RPSLS and to see the game come to life in a console environment!
