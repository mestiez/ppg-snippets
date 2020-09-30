//creating a light object with myself as a parent, a red colour, a radius of 5 units, and a brightness of 1 (default)
var glow = ModAPI.CreateLight(transform, Color.red, 5, 1);

//change the colour to whatever the hell
glow.Color = Color.yellow;

//blind the player
glow.Brightness = 1500;

//devour the world
glow.Radius = 1000;

//it's a component of a new child GameObject so you can set its position
glow.transform.localPosition = new Vector3(0,0,0);
