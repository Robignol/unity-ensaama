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

## Component (accès à une instance, ajouter, détruire)

Pour récup un composant existant sur un gameObject,
on utilise `GetComponent<MonComposant>()` par exemple:
```csharp
Rigidbody body = GetComponent<Rigidbody>();
```

Attention, le composant récupéré peut être nul (s'il n'existe pas)

pour ajouter un composant sur un gameObject, 
on utilise `gameObject.AddComponent<MonComposant>(); par exemple : 
```csharp
gameObject.AddComponent<Rigidbody>();
```
voir usage dans Target (eyes)

// aller voir README de Joseph.


## Debug

pour mettre pause : 
```csharp
Debug.Break();
```