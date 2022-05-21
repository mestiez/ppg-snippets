//clone settings because its safer this way or whatever the hell, I don't remember
var set = MapConfig.Instance.Settings.ShallowClone();

//do whatever

//set.Floodlights = false;
//set.Rain = true;
//set.Snow = false;
//set.Fog = true;
//etc.

//apply settings
MapConfig.Instance.ApplySettings(set);