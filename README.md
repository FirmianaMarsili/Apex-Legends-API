# Apex-Legends-API

**get your [API Key](https://portal.apexlegendsapi.com/)**

**replace[`YOUR_API_KEY`](https://github.com/FirmianaMarsili/Apex-Legends-API/blob/638cf284167855864b1d5fc045f7f90b6ccde115/Apex-Legends-API/ResponseBase.cs#L30)**

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
  
