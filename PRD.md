# PRD: TimeZone Comparator Blazor WASM App

## 1. Objectif
Créer une application web **Blazor WebAssembly (.NET 10)** qui :
- Détecte automatiquement le fuseau horaire du navigateur.
- Affiche l’heure locale détectée.
- Permet à l’utilisateur de comparer l’heure locale avec un ou plusieurs fuseaux horaires choisis.
- Est hébergée statiquement sur **GitHub Pages**.

## 2. Fonctionnalités Principales

### 2.1 Détection automatique du fuseau du navigateur
- Utilisation de `Intl.DateTimeFormat().resolvedOptions().timeZone` via **JS Interop**.
- Détection immédiate au chargement de la page.
- Affichage du fuseau détecté et de l’heure locale correspondante.

### 2.2 Comparateur de fuseaux horaires
- Dropdown ou multiselect pour choisir un ou plusieurs fuseaux cibles.
- Affichage de :
  - Heure locale.
  - Heure du fuseau cible.
  - Décalage horaire (heures et minutes).
- Mise à jour automatique toutes les secondes ou minute.
- Possibilité de comparer plusieurs fuseaux simultanément.

### 2.3 Interface utilisateur
- Simple et responsive :
  - Fuseau détecté + heure locale.
  - Sélecteur de fuseaux cibles.
  - Tableau ou cartes affichant la comparaison.
- Option “Mode clair / sombre” pour l’UI.
- Mise à jour dynamique côté client sans serveur.

## 3. Stack Technique

- **Frontend** : Blazor WebAssembly (.NET 10)
  - JS Interop pour récupérer le fuseau du navigateur.
  - Mise à jour temps réel via `Timer` côté WASM.
- **Gestion des fuseaux** : NodaTime 3.3.0
  - `DateTimeZoneProviders.Tzdb` pour fuseaux précis et DST.
  - Conversion `Instant → ZonedDateTime`.
- **Hébergement** : GitHub Pages (statique)
  - Déploiement via workflow GitHub Actions ou build manuel.
- **UI Framework** : Tailwind CSS ou Bootstrap (optionnel).
- slnx pour le fichier de solution.

## 4. Flux Utilisateur

1. L’utilisateur ouvre l’application depuis GitHub Pages.
2. L’application détecte le fuseau du navigateur via JS Interop.
3. L’heure locale est affichée instantanément.
4. L’utilisateur choisit un fuseau de comparaison dans une liste.
5. L’application affiche :
   - Heure locale.
   - Heure du fuseau cible.
   - Décalage.
6. Les heures se mettent à jour en temps réel côté client.

## 5. Contraintes & Exigences Techniques

- **100% côté client** : Pas besoin de serveur, compatible GitHub Pages.
- **Exactitude** : Utiliser NodaTime pour gérer correctement DST et heures historiques.
- **Performance** : Mise à jour en temps réel fluide sur WASM.
- **Compatibilité** : Edge, Chrome, Firefox, Safari.
- **Accessibilité** : Responsive et lisible sur mobile et desktop.
- **Tests** : Possibilité de simuler d’autres fuseaux via DevTools pour QA.

## 6. KPIs / Objectifs

- Temps de détection du fuseau < 1s après chargement.
- Heure locale et fuseaux cibles précis, avec DST et offsets corrects.
- Mise à jour dynamique côté client sans lag perceptible.

## 7. Extensions futures

- Comparaison multi-fuseaux avec visualisation graphique.
- Historique des comparaisons récentes côté client (localStorage).
- Mode “alarm/notification” pour correspondance d’heures spécifiques.
- Support mobile amélioré avec layout optimisé.
