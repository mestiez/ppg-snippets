//add a built-in component that invokes a delegate when the item receives an activation signal
Instance.AddComponent<UseEventTrigger>().Action = () =>
{
    ModAPI.Notify("I'VE BEEN USED!");
};
