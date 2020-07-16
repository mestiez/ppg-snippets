// register item to the mod api
ModAPI.Register(
    new Modification()
    {
        OriginalItem = ModAPI.FindSpawnable("Human"), //item to derive from
        NameOverride = "Human but blue -BH", //new item name with a suffix to assure it is globally unique
        DescriptionOverride = "From avatar!!!! (the one with the blue people).", //new item description
        CategoryOverride = ModAPI.FindCategory("Entities"), //new item category
        ThumbnailOverride = ModAPI.LoadSprite("blueMan.png"), //new item thumbnail (relative path)
        AfterSpawn = (Instance) => //all code in the AfterSpawn delegate will be executed when the item is spawned
        {
            //load textures for each layer (see Human textures folder in this repository)
            var skin = ModAPI.LoadTexture("blueSkin.png");
            var flesh = ModAPI.LoadTexture("blueFlesh.png");
            var bone = ModAPI.LoadTexture("blueBone.png");

            //use the helper function to set each texture
            //parameters are as follows: 
            //  skin texture, flesh texture, bone texture, sprite scale
            Instance.GetComponent<PersonBehaviour>().SetBodyTextures(skin, flesh, bone, 1);
        }
    }
);
