using Godot;
using System;
using System.Diagnostics;

public partial class level_1 : Node2D
{
    public void OnMazeBodyExited(RigidBody2D area2)
    {
        GetTree().ReloadCurrentScene();
    }
}
