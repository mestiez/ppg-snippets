//add a built-in component that invokes a delegate when the item receives an activation signal
Instance.AddComponent<UseEventTrigger>().Action = () =>
{
    //everything inside this delegate will be executed
    
    //show a notification to the player
    ModAPI.Notify("I'VE BEEN USED!");
};
