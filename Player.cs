using Godot;
using System;

public partial class Player : Node2D
{
	[Export]
	public float Speed = 2.00f;
	
	public Vector2 screensize = new Vector2(480.00f, 720.00f);
	
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		GetNode<AnimatedSprite2D>("Area2D/AnimatedSprite2D").Play("idle");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (Input.IsActionPressed("ui_right"))
		{
			Position += new Vector2(Speed, 0);
			GetNode<AnimatedSprite2D>("Area2D/AnimatedSprite2D").Play("run");
			GetNode<AnimatedSprite2D>("Area2D/AnimatedSprite2D").FlipH = false;
		}
		else if (Input.IsActionPressed("ui_left"))
		{
			Position += new Vector2(-Speed, 0);
			GetNode<AnimatedSprite2D>("Area2D/AnimatedSprite2D").Play("run");
			GetNode<AnimatedSprite2D>("Area2D/AnimatedSprite2D").FlipH = true;
		}
		else
		{
			GetNode<AnimatedSprite2D>("Area2D/AnimatedSprite2D").Play("idle");
		}
	}
}
