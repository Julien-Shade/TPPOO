# Solution TP6 : Principe de Responsabilité Unique (SRP)

Cette solution démontre l'application du principe SRP (Single Responsibility Principle) au système de sauvegarde d'un jeu.

## Classes créées

### 1. `PlayerData.cs`
- **Responsabilité** : Stocker les données du joueur à sauvegarder.
- **Raison unique de changer** : Modifications des attributs du joueur qui doivent être sauvegardés.

### 2. `DataSerializer.cs`
- **Responsabilité** : Convertir des objets en données binaires et vice-versa.
- **Raison unique de changer** : Modification du format de sérialisation (par exemple, passer de JSON à XML ou binaire).

### 3. `DataCompressor.cs`
- **Responsabilité** : Compresser et décompresser des données.
- **Raison unique de changer** : Modification de l'algorithme de compression ou de ses paramètres.

### 4. `DataEncryptor.cs`
- **Responsabilité** : Chiffrer et déchiffrer des données.
- **Raison unique de changer** : Modification de l'algorithme de chiffrement ou de ses paramètres.

### 5. `FileStorage.cs`
- **Responsabilité** : Gérer les interactions avec le système de fichiers.
- **Raison unique de changer** : Modification du système de stockage (par exemple, passer du stockage local à un stockage en ligne).

### 6. `UIMessageDisplay.cs`
- **Responsabilité** : Afficher des messages à l'utilisateur.
- **Raison unique de changer** : Modification de l'interface utilisateur ou du comportement des notifications.

### 7. `SaveManager.cs` (refactorisé)
- **Responsabilité** : Coordonner le processus de sauvegarde et de chargement.
- **Raison unique de changer** : Modification du flux de sauvegarde/chargement.

## Avantages de cette approche

### 1. Meilleure organisation du code
- Chaque classe a une responsabilité claire et bien définie
- Il est plus facile de comprendre ce que fait chaque partie du code

### 2. Facilité de maintenance
- Les modifications dans une fonctionnalité n'affectent pas les autres
- Par exemple, changer l'algorithme de chiffrement n'impacte que la classe `DataEncryptor`

### 3. Testabilité améliorée
- Chaque composant peut être testé indépendamment
- Il est possible d'écrire des tests unitaires spécifiques pour chaque responsabilité

### 4. Réutilisabilité
- Les composants peuvent être utilisés dans d'autres parties du projet
- Par exemple, `DataEncryptor` pourrait être utilisé pour chiffrer les communications réseau

### 5. Extensibilité
- Il est facile d'ajouter de nouvelles fonctionnalités sans modifier le code existant
- Par exemple, ajouter un système de sauvegarde automatique ne nécessiterait pas de modifier les composants existants

## Comment utiliser cette solution

1. Le `SaveManager` reste le point d'entrée principal pour sauvegarder et charger des données
2. Il coordonne les différents services mais ne contient plus les détails d'implémentation
3. Pour modifier un aspect du système (par exemple, le format de stockage), il suffit de modifier la classe correspondante sans toucher aux autres

## Diagramme de classes

```
+-----------------+     +-----------------+     +-----------------+
|   SaveManager   |---->| DataSerializer  |     |    PlayerData   |
+-----------------+     +-----------------+     +-----------------+
         |
         |
         v
+-----------------+     +-----------------+     +-----------------+
| DataCompressor  |     |  DataEncryptor  |     |  FileStorage   |
+-----------------+     +-----------------+     +-----------------+
         |
         |
         v
+-----------------+
| UIMessageDisplay|
+-----------------+
```