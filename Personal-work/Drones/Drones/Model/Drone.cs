using Drones.Helpers;
using Drones.Properties;
using Drones.Configuration;

namespace Drones
{
    // Cette partie de la classe Drone définit ce qu'est un drone par un modèle numérique
    public partial class Drone
    {

        private int objectifX;
        private int objectifY;

        private int charge;                           // La charge actuelle de la batterie
        public int Charge {
            get { return charge; } set { charge = value; }
        }

        private string name;                           // Un nom
        public string Name{
            get { return name; } set { name = value; }
        }

        private int x;                                 // Position en X depuis la gauche de l'espace aérien
        public int X
        {
            get { return x; } set { x = value; }
        }

        private int y;                                 // Position en Y depuis le haut de l'espace aérien
        public int Y
        {
            get { return y; } set { y = value; }
        }

        // Constructeur
        public Drone(int x, int y, string name)
        {
            Random alea = new Random();
            this.x = x;
            this.y = y;
            this.name = name;
            charge = Config.MAX_LOAD; // La charge initiale de la batterie est choisie aléatoirement

            objectifX = alea.Next(0, Config.AIRSPACE_WIDTH);
            objectifY = alea.Next(0, Config.AIRSPACE_HEIGHT);
        }


        #region ================ Modelisation du drone et de son comportement ================

        // Cette méthode calcule le nouvel état dans lequel le drone se trouve après
        // que 'interval' millisecondes se sont écoulées
        public void Update(int interval)
        {
            if (charge <= 0) return; // S'il n'a plus de charge, il ne peut plus bouger

            double distanceAxeX = objectifX - x;
            double distanceAxeY = objectifY - y;
            double distanceReelDiagonale = Math.Sqrt(distanceAxeX * distanceAxeX + distanceAxeY * distanceAxeY);
            double step = (double)Config.SPEED * interval / 1000;
            Console.WriteLine(step);

            if (distanceReelDiagonale < 1 ) return;

            x += (int)(distanceAxeX / distanceReelDiagonale * step);
            y += (int)(distanceAxeY / distanceReelDiagonale * step);
                                 
            /*Random alea = new Random();
            x += 2;                                    // Il s'est déplacé de 2 pixels vers la droite
            y += alea.Next(-2, 3);                     // Il s'est déplacé d'une valeur aléatoire vers le haut ou le bas*/
            charge--;                                  // Il a dépensé de l'énergie
        }

        #endregion

        #region  ================ Rendu graphique  ================

        private const int SIZE = 50;
        private Pen droneBrush = new Pen(new SolidBrush(Color.Purple), 3);

        // De manière graphique
        public void Render(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.DrawImage(charge > 0 ? Resources.drone : Resources.boom, x-Drone.SIZE/2, y - Drone.SIZE / 2, Drone.SIZE, Drone.SIZE);
            drawingSpace.Graphics.DrawString($"{this}", TextHelpers.drawFont, TextHelpers.writingBrush, x + 5, y - 25);
        }

        // De manière textuelle
        public override string ToString()
        {
            return $"{name} ({(int)((double)charge / Config.MAX_LOAD * 100)}%)";
        }
        #endregion

    }
}
