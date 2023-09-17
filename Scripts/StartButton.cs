using Godot;
using System;

public partial class StartButton : Button
{
	public override void _Ready()
	{
		this.Pressed += () => OnClick();
	}
 
	private void OnClick()
	{
		var level1Scene  = ResourceLoader.Load<PackedScene>("res://Scenes/Player/player.tscn");
		GetTree().ChangeSceneToPacked(level1Scene);
	}
}
