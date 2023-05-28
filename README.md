# WeaponSway Script

The WeaponSway script adds a weapon sway effect to a GameObject in Unity based on mouse input. It calculates the mouse movement on the X and Y axes and applies rotation to the GameObject accordingly to create a realistic sway effect. Additionally, it provides visual feedback by drawing Gizmos to visualize the player's look direction and the direction to another object.

## Features

- Realistic weapon sway effect based on mouse input
- Smooth rotation interpolation using Quaternion.Slerp
- Visual feedback using Gizmos to visualize the player's look direction and object direction

## Getting Started

1. Attach the WeaponSway script to the GameObject that represents your weapon or object in Unity.
2. Adjust the smooth and multiplier values in the inspector to fine-tune the sway effect.
3. Ensure that the mouse input is correctly set up in your Unity project.

## Usage

- Move the mouse horizontally (Mouse X axis) to rotate the GameObject around the vertical axis.
- Move the mouse vertically (Mouse Y axis) to rotate the GameObject around the horizontal axis.
- The GameObject will smoothly rotate to simulate a weapon sway effect.

## Visual Feedback

The script provides visual feedback using Gizmos to visualize the player's look direction and the direction to another object (specified by the "kub" variable).

- A white line is drawn from the player's position to the other object, representing the direction from the player to the object.
- A yellow line is drawn from the player's position in the direction of the player's look direction.

If the player's look direction and the direction to the other object have a dot product greater than or equal to the preciseness value, the object specified by "kub" will be destroyed.

Thanks for reading

