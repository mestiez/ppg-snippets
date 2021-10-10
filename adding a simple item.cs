// register item to the mod api
ModAPI.Register(
    new Modification()
    {
        OriginalItem = ModAPI.FindSpawnable("Knife"), //item to derive from
        NameOverride = "Dagger -MoreMelee", //new item name with a suffix to assure it is globally unique
        DescriptionOverride = "It is a dagger.", //new item description
        CategoryOverride = ModAPI.FindCategory("Melee"), //new item category
        ThumbnailOverride = ModAPI.LoadSprite("daggerView.png"), //new item thumbnail (relative path)
        AfterSpawn = (Instance) => //all code in the AfterSpawn delegate will be executed when the item is spawned
        {
            //get the SpriteRenderer and replace its sprite with a custom one
            Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("dagger.png"); 
        }
    }
);
