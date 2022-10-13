#!/bin/bash

echo "Entered main script."

ServerDir=/var/www/nexus
NexusData=/nexus-data

AppSettingsVolume=/nexus-data/appsettings.json
AppSettingsWww=/var/www/nexus/appsettings.json

if [ ! -f "$AppSettingsVolume" ]; then
	echo "Copying appsettings.json to volume."
	cp "$AppSettingsWww" "$AppSettingsVolume"
fi

if [ -f "$AppSettingsWww" ]; then
	rm "$AppSettingsWww"
fi

ln -s "$AppSettingsVolume" "$AppSettingsWww"

echo "Starting Nexus server."
exec /usr/bin/dotnet /var/www/nexus/Nexus_Server.dll