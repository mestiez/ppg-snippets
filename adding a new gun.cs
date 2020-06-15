ModAPI.Register(
    new Modification()
    {
        OriginalItem = ModAPI.FindSpawnable("Pistol"), //item to derive from
        NameOverride = "Mauser C96 -TooManyGuns", //new item name with a suffix to assure it is globally unique
        DescriptionOverride = "World War era pistol developed by the Germans.", //new item description
        CategoryOverride = ModAPI.FindCategory("Firearms"), //new item category
        ThumbnailOverride = ModAPI.LoadSprite("c96view.png"), //new item thumbnail (relative path)
        AfterSpawn = (Instance) => //all code in the AfterSpawn delegate will be executed when the item is spawned
        {
            //setting the sprite
            Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("C96.png");

            //getting the FirearmBehaviour for later manipulation
            var firearm = Instance.GetComponent<FirearmBehaviour>();

            //creating a custom cartridge for the gun
            Cartridge customCartridge = ModAPI.FindCartridge("9mm"); //load an instanced 9mm cartridge
            customCartridge.name = "7.63×25mm Mauser"; //set a name
            customCartridge.Damage *= 0.8f; //change the damage however you like
            customCartridge.StartSpeed *= 1.5f; //change other properties

            //set the cartridge to the FirearmBehaviour
            firearm.Cartridge = customCartridge;

            //set the new gun sounds. this is an array of AudioClips that is picked from at random when shot
            firearm.ShotSounds = new AudioClip[]
            {
                ModAPI.LoadSound("c96_1.wav"),
                ModAPI.LoadSound("c96_2.wav"),
                ModAPI.LoadSound("c96_3.wav"),
            };

            // set the collision box to the new sprite shape
            // this is the easiest way to fix your collision shape, but it also the slowest.
            Instance.FixColliders();
        }
    }
);
