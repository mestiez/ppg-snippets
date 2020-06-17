ModAPI.Register(new Modification()
{
    //set item details
    OriginalItem = ModAPI.FindSpawnable("Knife"),
    NameOverride = "Epic knife that sparks when you use it",
    DescriptionOverride = "not a single soul knows why this exists",
    ThumbnailOverride = ModAPI.LoadSprite("sparkknife_view.png"),
    
    AfterSpawn = (Instance) =>
    {
        //add a UseEventTrigger and set its action
        Instance.AddComponent<UseEventTrigger>().Action = () => {
          //spawn an effect by the name of "Spark" at the transform position
          ModAPI.CreateParticleEffect("Spark", Instance.transform.position);
        };
    }
});
