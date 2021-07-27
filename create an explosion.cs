//The most basic explosion function. Give a position and a strength and the rest is assumed from these values.
ExplosionCreator.Explode(transform.position, 2);


// -- OR --


//Call the full explosion function for more control
ExplosionCreator.Explode(new ExplosionCreator.ExplosionParameters
{
    //Explosion center
    Position = transform.position,

    //Should particles be created and sound played? 
    CreateParticlesAndSound = true,

    //Should the particles, if created, be that of a large explosion?
    LargeExplosionParticles = false,
    
    //The chance that limbs are torn off (0 - 1, 1 meaning all limbs and 0 meaning none)
    DismemberChance = 0.1f,

    //The amount of force for each "fragment" of the explosion. 8 is a pretty powerful explosion. 2 is a regular explosion.
    FragmentForce = 8,

    //The amount of rays cast to simulate fragments. More rays is more lag but higher precision
    FragmentationRayCount = 32,

    //The ultimate range of the explosion
    Range = 10
});