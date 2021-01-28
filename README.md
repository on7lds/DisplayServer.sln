# DisplayServer.sln
Windows version of [DisplayServer](https://github.com/BrandMeister/DisplayServer) which uses windows from Windows as screen.


## Executable
If you do not want to compile it yourself, just copy the binary from the [DisplayServer/bin/Release](DisplayServer/bin/Release) directory


## Configuration
Settings are taken to the registry.  
When starting the first time, DisplayServer writes the configuration to expect the data to come on UDP 224.1.2.3:62001

This is also the address you have to configure for DMRHost in MMDVM.ini

##### MMDVM.ini for DMRHost extract :
```
[Display]
Enable=1
# DMRHost connects to Displayserver at Address:Port
Address=224.1.2.3
Port=62001
# DisplayServer listens on ListenAddress:ListenPort
ListenAddress=224.1.2.3
ListenPort=62001
```

