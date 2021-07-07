***** Police Management v2.0 - BY DrWyatt ****
Join https://discord.me/drwyatt for support, new releases and much more!

## HOW TO INSTALL ##
> Copy the folder "[policepack]" that's located inside "In Resources" to your FiveM's Server RESOURCES folder.
> Add "start policeManagement" to your server.cfg

## MANAGEMENT COMMANDS (RCON) ##
> "pmaddpd <Department's Acronym> <Department's Name>"
> "pmaddfd <Department's Acronym> <Department's Name>"
> "pmaddadmin <Player's ID>"
> "pmaddcop <Player's ID> <Department's ID>"
> "pmaddff <Player's ID> <Department's ID>"

> "pmlistpds"
> "pmlistfds"
> "pmlistadmins"
> "pmlistcops"
> "pmlistffs"

> "pmremovepd <Department's ID>"
> "pmremovefd <Department's ID>"
> "pmremoveadmin <Admin's ID>"
> "pmremovecop <Cop's ID>"
> "pmremoveff <Firefighter's ID>"

> "pmcleardb"
> "pmclearpds"
> "pmclearfds"
> "pmclearadmins"
> "pmclearcops"
> "pmclearffs"

## MANAGEMENT COMMANDS (IN-GAME) ##
> All in-game commands are the same as the RCON ones with a "/" in front of it, 
  "pmaddadmin" and "pmremoveadmin" are not available in-game.
  
> "/cops" | Lists all on-duty cops
> "/firefighters" | Lists all on-duty firefighters
> "/odc" or "/ondutycop" | Get on-duty as a Police Officer
> "/odf" or "/ondutyfire" | Get on-duty as a firefighter
> "/ofd" or "/offduty" | Get off-duty
> "/funitid [Callsign]" | Change your FD callsign
> "/punitid [Callsign]" | Change your PD callsign

## EVENTS (FOR DEVELOPERS) ##
> For now you can check if a player is an officer or triggering something to all (admins/cops/department's cops) by triggering
  these server events with the event to be triggered.

> "pm:isAdmin" (int playerSID, string eventName)
> "pm:isCop" (int playerSID, string eventName)
> "pm:triggerToAllCops" (string eventName, string argument)
> "pm:triggerToAllAdmins" (string eventName, string argument)
> "pm:triggerToAllDepartment" (int departmentID, string eventName, string argument)

## SOURCE CODE ##
> The source code for this program will be closed source until the main developer (DrWyatt) decides to release it in a platform of his choice.
> When released, the source code for this product can be forked but is obligated to follow the GPL-3.0 

## LICENSE ##
> Police Management is protected under Copyright GPL-3.0 LICENSE
> Do not re-distribute under a different name
> Do not re-distribute unless authorized by DrWyatt

## CONTRIBUTORS ##
DrWyatt - Main Developer

