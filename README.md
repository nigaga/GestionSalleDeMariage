# Gestion Salle de Mariage

Application web ASP.NET Core MVC pour la gestion d'une salle de mariage.

## Fonctionnalités
- Authentification simple (admin uniquement)
- Gestion des clients (CRUD)
- Gestion des réservations (CRUD, pas de doublon de date)
- Interface Bootstrap
- Utilisation d'Entity Framework Core et SQL Server LocalDB


## Lancement du projet

1. **Cloner ou télécharger le projet**
2. Ouvrir un terminal dans le dossier du projet
3. Exécuter la commande suivante :
   ```bash
   dotnet run --project GestionSalleDeMariage/GestionSalleDeMariage.csproj
   ```
4. Ouvrir le navigateur à l'adresse affichée (ex : http://localhost:5264)
5. Se connecter avec :
   - **Nom d'utilisateur** : `admin`
   - **Mot de passe** : `admin123`

## Structure du projet
- `Models/` : Entités EF Core (Client, Reservation)
- `Controllers/` : Contrôleurs MVC
- `Views/` : Vues Razor (CRUD, Login)
- `appsettings.json` : Configuration (connexion SQL)

## Personnalisation
- Pour changer le mot de passe admin, modifier `AccountController.cs`.
- Pour utiliser un autre SQL Server, modifier la chaîne de connexion dans `appsettings.json`.

## Sécurité
- Ce projet est un exemple pédagogique. Pour un usage réel, il faut :
  - Gérer les mots de passe de façon sécurisée
  - Ajouter une gestion d'utilisateurs complète
  - Protéger contre les attaques courantes (XSS, CSRF, etc.)

