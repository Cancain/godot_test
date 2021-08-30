using Godot;
using System;

public class Sprite : Godot.Sprite
{

  private UInt32 velocity = 3;
  public override void _Ready()
  {

  }

  public override void _Process(float delta)
  {
    handleInput();
  }

  private void handleInput()
  {
    if (Input.IsActionJustPressed("ui_cancel"))
    {
      GetTree().Quit();
    }

    if (Input.IsActionPressed("ui_up"))
    {
      Position = new Vector2(Position.x, Position.y - velocity);
    }
    if (Input.IsActionPressed("ui_down"))
    {
      Position = new Vector2(Position.x, Position.y + velocity);
    }
    if (Input.IsActionPressed("ui_left"))
    {
      Position = new Vector2(Position.x - velocity, Position.y);
    }
    if (Input.IsActionPressed("ui_right"))
    {
      Position = new Vector2(Position.x + velocity, Position.y);
    }
  }
}
