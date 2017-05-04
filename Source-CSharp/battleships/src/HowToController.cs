using System;
using System.Collections;
using System.Collections.Generic;
//using System.Data;
using System.Diagnostics;
using System.IO;
using SwinGameSDK;
namespace Battleships
{
/// <summary>
/// Controls displaying How to play battleship
/// </summary>
static class HowToController
{
	private const int NAME_WIDTH = 3;

	private const int SCORES_LEFT = 490;


	/// <summary>
	/// Draws the high scores to the screen.
	/// </summary>
	public static void DrawHowTo()
	{
        const int ESCAPE_HEADING = 575;
        const int ESCAPE_TOP = 560; 

        
		SwinGame.DrawText("   Escape - To Main Menu  ", Color.White, GameResources.GameFont("Courier"), ESCAPE_HEADING, ESCAPE_TOP);
	}

	/// <summary>
	/// Handles the user input during the How to screen.
	/// </summary>
	/// <remarks></remarks>
	public static void HandleHowToInput()
	{
		if (SwinGame.MouseClicked(MouseButton.LeftButton) || SwinGame.KeyTyped(KeyCode.vk_ESCAPE) || SwinGame.KeyTyped(KeyCode.vk_RETURN)) {
			GameController.EndCurrentState();
		}
	}
}
}