using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.GL
{
    class GameObject
    {
        public char DisplayCharacter;
        public GameCell CurrentCell;
        public GameObjectType type;

        public GameObject(GameObjectType type, char displayCharacter)
        {
            this.type = type;
            this.DisplayCharacter = displayCharacter;
        }

        public GameObjectType GetGameObjectType(char displayCharacter)
        {
            return this.type;
        }
    }

    enum GameObjectType
    {
        WALL,

        PLAYER,

        ENEMY,

        REWARD,

        NONE
    }
}
