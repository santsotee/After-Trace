# After Trace

After Trace is a Unity gameplay programming project focused on enemy AI, steering behaviours, finite state machines, and reusable gameplay systems.

This repository contains a curated selection of the C# systems developed for the project. The complete playable version is available on itch.io.

## Project Overview

After Trace is a score-based arcade game in which the player must survive encounters with enemies that use different movement and behavioural patterns.

The gameplay was intentionally kept simple so the development could focus on clean code, modular architecture, enemy behaviours, and reusable systems.

## Technical Features

- Finite State Machine (FSM)
- Steering Behaviours
- Enemy AI
- Mirror Movement System
- Event-Driven Programming
- Object Pooling
- Modular Enemy Architecture
- Component-Based Design

## Repository Structure

```text
After-Trace/
├── AI/
│   ├── States/
│   ├── StateMachine/
│   └── Behaviours/
├── Movement/
│   ├── Steering/
│   └── MirrorMovement/
├── Core/
│   ├── Events/
│   └── ObjectPooling/
├── Gameplay/
│   ├── Enemies/
│   ├── Spawning/
│   └── Score/
└── README.md
```

The repository only includes relevant gameplay programming systems. Art, audio, scenes, third-party assets, and other files unrelated to the code showcase have been excluded.

## Technical Challenges

### Mirror Movement Enemy

One of the main challenges was creating an enemy capable of mirroring the player's movement while maintaining consistent, responsive, and readable gameplay interactions.

The system was separated from the enemy's general logic to keep the movement behaviour reusable and easier to maintain.

### Enemy Extensibility

Enemy behaviours were designed as modular components, allowing new enemy types and movement patterns to be introduced without rewriting existing systems.

This approach reduces code duplication and keeps responsibilities separated.

### Runtime Performance

Object pooling was implemented for frequently instantiated gameplay objects, reducing unnecessary creation and destruction during gameplay.

## Architecture Concepts

- State Pattern
- Event-Driven Architecture
- Component-Based Design
- Object Pooling
- Separation of Responsibilities
- Reusable Gameplay Components
- Extensible Enemy Behaviours

## Key Learnings

- Designing extensible gameplay systems
- Building reusable enemy architectures
- Implementing AI through state-driven systems
- Separating movement, behaviour, and gameplay responsibilities
- Reducing dependencies between systems
- Improving maintainability through modular design
- Applying optimisation techniques in a gameplay context

## Technologies

- Unity
- C#
- Git
- Visual Studio

## Play the Game

The complete playable version is available on itch.io:

PEGÁ_ACÁ_TU_LINK_DE_ITCHIO

## About This Repository

This repository is intended as a programming portfolio piece. It presents selected code from the project rather than the complete Unity project.

The code is organised by responsibility so that the implementation of AI, movement, events, object pooling, and gameplay systems can be reviewed independently.
