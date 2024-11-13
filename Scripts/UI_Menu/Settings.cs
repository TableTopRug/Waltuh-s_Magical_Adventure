using Godot;
using System;

public partial class Settings : PanelContainer
{
	[ExportGroup("Menu Music")]
	[Export]
	public float menuMusicVol = 0;


	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public void OnSliderValueChanged(float val) {
		menuMusicVol = val;
		GD.Print(menuMusicVol);
	}
}