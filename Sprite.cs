using Godot;
using System;

public class Sprite : Godot.Sprite
{
  // Declare member variables here. Examples:
  // private int a = 2;
  // private string b = "text";

  // Called when the node enters the scene tree for the first time.
  public override void _Ready()
  {

  }

  // Called every frame. 'delta' is the elapsed time since the previous frame.
  public override void _Process(float delta)
  {
    Position = new Vector2(Position.x + 3, Position.y);
    GD.Print(Position.x);
  }
}
