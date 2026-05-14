# UniNet.PubSubMessages

A service for sending network messages in publisher/subscriber mode. Unlike the classic PubSub pattern, the publisher knows about subscribers and receives subscription events.

The implementation is based on Mirror library, but abstractions allow for integration with other network libraries.

The Mirror implementation requires the Mirror package to be pre-installed. You can install it from the Unity Asset Store or via Git from my fork:
```
https://github.com/KarenKrill/Mirror.Fork.git?path=Assets/Mirror
```

Some samples requires Zenject/Extenject to be pre-installed:
```
https://github.com/modesttree/Zenject.git?path=UnityProject/Assets/Plugins/Zenject
```