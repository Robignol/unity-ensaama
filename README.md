# unity-ensaama

## vie et mort
Pour détruire un conmposant ou un gameObject :
```csharp
Destroy(gameObject);
// avec un délai :
Destroy(gameObject, 3f);
```

Pour créer un gameObject à partir d'un source :
-existant dans la scène :
```csharp
Instantiate(gameObject);
```
-en récupérant l'instance crée pour la détruire ensuite :
```csharp
GameObject clone = Instantiate(gameObject);
Destroy(clone, 5f);
```
[voir usage CloneOnClick.cs](./Assets/CloneOnClick.cs)