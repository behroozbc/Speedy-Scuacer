using Godot;
using System;

public partial class player : RigidBody2D
{
    const int positiveForce = 1000;
    public override void _PhysicsProcess(double delta)
    {
        if (Input.IsActionPressed("move_right"))
            ApplyForce(new Vector2(positiveForce, 0));
        if (Input.IsActionPressed("move_left"))
            ApplyForce(new Vector2(-positiveForce, 0));
        if (Input.IsActionPressed("move_up"))
            ApplyForce(new Vector2(0,-positiveForce));
        if (Input.IsActionPressed("move_down"))
            ApplyForce(new Vector2(0,positiveForce));
        base._PhysicsProcess(delta);
    }
}
