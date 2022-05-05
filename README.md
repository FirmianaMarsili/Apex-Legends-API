# Apex-Legends-API

**get your [API Key](https://portal.apexlegendsapi.com/)**

**replace[`YOUR_API_KEY`](https://github.com/FirmianaMarsili/Apex-Legends-API/blob/fa0461eb2aa09e044c030f8d575536e35f62fe1f/Apex-Legends-API/ResponseBase.cs#L30)**

Examples：
  ```
    var bridge = new Bridge()
    {
        Player = "",
        Platform = Platform.PC
    };
    var userdata = await bridge.GetResponseAsync();
    if (userdata.Success)
    {
        Console.WriteLine(userdata.Global.Uid);
    }
  ```
  # https://apexlegendsapi.com/
  
# Apex-Legends-API
# Apex-Legends-API
