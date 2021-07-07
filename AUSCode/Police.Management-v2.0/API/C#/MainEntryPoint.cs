public INSERT_PLUGIN_NAME_HERE(){
	//Add your startup code here
	PolM("INSERT_PLUGIN_NAME_WITHOUT_SPACES")	
}

private void PolM(string pluginName)
{
	pm.Checks(pluginName);
    EventHandlers.Add(pluginName + ":isCop", new Action<string, int>(pm.IsCop));
    EventHandlers.Add(pluginName + ":isNotCop", new Action(pm.IsNotCop));
    EventHandlers.Add(pluginName + ":isFire", new Action<string, int>(pm.IsFire));
    EventHandlers.Add(pluginName + ":isNotFire", new Action(pm.IsNotFire));
    EventHandlers.Add(pluginName + ":isAdmin", new Action(pm.IsAdmin));
    EventHandlers.Add(pluginName + ":isNotAdmin", new Action(pm.IsNotAdmin));
}