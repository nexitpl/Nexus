#!/bin/bash
HostName=
Organization=
GUID=$(cat /proc/sys/kernel/random/uuid)
UpdatePackagePath=""


Args=( "$@" )
ArgLength=${#Args[@]}

for (( i=0; i<${ArgLength}; i+=2 ));
do
    if [ "${Args[$i]}" = "--uninstall" ]; then
        systemctl stop nexus-agent
        rm -r -f /usr/local/bin/Nexus
        rm -f /etc/systemd/system/nexus-agent.service
        systemctl daemon-reload
        exit
    elif [ "${Args[$i]}" = "--path" ]; then
        UpdatePackagePath="${Args[$i+1]}"
    fi
done

UbuntuVersion=$(lsb_release -r -s)

wget -q https://packages.microsoft.com/config/ubuntu/$UbuntuVersion/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
dpkg -i packages-microsoft-prod.deb
apt-get update
apt-get -y install apt-transport-https
apt-get update
apt-get -y install dotnet-runtime-6.0
rm packages-microsoft-prod.deb

apt-get -y install libx11-dev
apt-get -y install libxrandr-dev
apt-get -y install unzip
apt-get -y install libc6-dev
apt-get -y install libgdiplus
apt-get -y install libxtst-dev
apt-get -y install xclip
apt-get -y install jq
apt-get -y install curl


if [ -f "/usr/local/bin/Nexus/ConnectionInfo.json" ]; then
    SavedGUID=`cat "/usr/local/bin/Nexus/ConnectionInfo.json" | jq -r '.DeviceID'`
     if [[ "$SavedGUID" != "null" && -n "$SavedGUID" ]]; then
        GUID="$SavedGUID"
    fi
fi

rm -r -f /usr/local/bin/Nexus
rm -f /etc/systemd/system/nexus-agent.service

mkdir -p /usr/local/bin/Nexus/
cd /usr/local/bin/Nexus/

if [ -z "$UpdatePackagePath" ]; then
    echo  "Downloading client..." >> /tmp/Nexus_Install.log
    wget $HostName/Content/Nexus-Linux.zip
else
    echo  "Copying install files..." >> /tmp/Nexus_Install.log
    cp "$UpdatePackagePath" /usr/local/bin/Nexus/Nexus-Linux.zip
    rm -f "$UpdatePackagePath"
fi

unzip ./Nexus-Linux.zip
rm -f ./Nexus-Linux.zip
chmod +x ./Nexus_Agent
chmod +x ./Desktop/Nexus_Desktop


connectionInfo="{
    \"DeviceID\":\"$GUID\", 
    \"Host\":\"$HostName\",
    \"OrganizationID\": \"$Organization\",
    \"ServerVerificationToken\":\"\"
}"

echo "$connectionInfo" > ./ConnectionInfo.json

curl --head $HostName/Content/Nexus-Linux.zip | grep -i "etag" | cut -d' ' -f 2 > ./etag.txt

echo Creating service... >> /tmp/Nexus_Install.log

serviceConfig="[Unit]
Description=The Nexus agent used for remote access.

[Service]
WorkingDirectory=/usr/local/bin/Nexus/
ExecStart=/usr/local/bin/Nexus/Nexus_Agent
Restart=always
StartLimitIntervalSec=0
RestartSec=10

[Install]
WantedBy=graphical.target"

echo "$serviceConfig" > /etc/systemd/system/nexus-agent.service

systemctl enable nexus-agent
systemctl restart nexus-agent

echo Install complete. >> /tmp/Nexus_Install.log
