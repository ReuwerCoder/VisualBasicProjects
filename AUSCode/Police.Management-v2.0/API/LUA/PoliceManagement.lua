local pluginName = "CHANGE_ME"

local isCop = false
local isFire = false
local isAdmin = false

local callsign
local department

Citizen.CreateThread(function()
    while true do
        Citizen.Wait(1000)
        TriggerServerEvent("pm:isCop", GetPlayerServerId(PlayerId()), pluginName .. ":isCop", pluginName .. ":isNotCop")
		TriggerServerEvent("pm:isAdmin", GetPlayerServerId(PlayerId()), pluginName .. ":isAdmin", pluginName .. ":isNotAdmin")
		TriggerServerEvent("pm:isFire", GetPlayerServerId(PlayerId()), pluginName .. ":isFire", pluginName .. ":isNotFire")
    end
end)

RegisterNetEvent(pluginName..':isCop')
AddEventHandler(pluginName..':isCop', function(callsignR, departmentR)
    callsign = callsignR
    department = departmentR
    isCop = true
end)

RegisterNetEvent(pluginName..':isNotCop')
AddEventHandler(pluginName..':isNotCop', function()
    isCop = false
end)

RegisterNetEvent(pluginName..':isFire')
AddEventHandler(pluginName..':isFire', function(callsignR, departmentR)
    callsign = callsignR
    department = departmentR
    isFire = true
end)

RegisterNetEvent(pluginName..':isNotFire')
AddEventHandler(pluginName..':isNotFire', function()
    isFire = false
end)

RegisterNetEvent(pluginName..':isAdmin')
AddEventHandler(pluginName..':isAdmin', function()
    isAdmin = true
end)

RegisterNetEvent(pluginName..':isNotAdmin')
AddEventHandler(pluginName..':isNotAdmin', function()
    isAdmin = false
end)

RegisterCommand('testcmd', function()
	if isCop == true then
		TriggerEvent("chatMessage", "TEST", {255, 255, 255}, "You are a cop")
	else
		TriggerEvent("chatMessage", "TEST", {255, 255, 255}, "You are not a cop")
	end
	
	if isAdmin == true then
		TriggerEvent("chatMessage", "TEST", {255, 255, 255}, "You are an admin")
	else
		TriggerEvent("chatMessage", "TEST", {255, 255, 255}, "You are not an admin")
	end
end)