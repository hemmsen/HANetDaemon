Push-Location C:\Users\mat\source\repos\HANetDaemon
dotnet build
dotnet publish -o /config/netdaemon3
Pop-Location

Push-Location C:\config
# ssh root@homeassistant.local -p 222
# rsync -avc -e "ssh -p 2232" . root@192.168.86.33:config/netdaemon3

scp -P 222 -r .\netdaemon3\ root@192.168.86.33:config/netdaemon3
Pop-Location
