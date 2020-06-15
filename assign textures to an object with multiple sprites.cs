//get the RandomSpriteBehaviour from the object (if it has one) and assign an array of your sprites to it
Instance.GetComponent<RandomSpriteBehaviour>().sprites = new Sprite[]
{
    ModAPI.LoadSprite("ball_1.png"),
    ModAPI.LoadSprite("ball_2.png"),
    ModAPI.LoadSprite("ball_3.png"),
    ModAPI.LoadSprite("ball_4.png"),
};
