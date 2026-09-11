# Drones

## Etape 2

> Dans laquelle le drone apprend à gérer son vol et nous on pratique l'ajout de code dans une classe

- Le drone est caractérisé par un état qui est un parmi: [CRASH,LOW_BATTERY,LOADING, ROAMING]. Définir une `enum` nommée `State` dans la classe `Drone`, ajouter une propriété publique `State`. L'état initial du drone est `ROAMING`.
- Quand il est en ROAMING, l'objectif est choisi de manière aléatoire et quand il l'atteint, un nouvel objectif et choisi aléatoirement.
- L'espace aérien dispose d'une borne de recharge. Créer une classe `Charger`. Elle à deux attributs de position \_x et \_y. Elle a une méthode Render similaire à celle du drone, qui la dessine à l'écran sous la forme d'un rond de 20 pixels de diamètre.
- Lorsque la batterie atteint un niveau de charge bas, le drone se met en état `LOW_BATTERY`. Quand il est dans cet état, son objectif est la borne de recharge.
- Quand le drone atteint la borne, il passe en état `LOADING`. Il arrête de se déplacer et sa batterie se recharge au lieu de se décharger (la recharge est 10 fois plus rapide que la décharge)
- Quand le la batterie du drone est pleine, il se remet en `ROAMING`

Indice: les attributs privés de position \_x et \_y permettent de dessiner le drone. Mais la position à prendre en compte pour ses déplacements/collisions est en son centre !  Créez deux propriétés publiques `X` et `Y` qui donnent la position réelle du drone dans l'espace aérien. 
