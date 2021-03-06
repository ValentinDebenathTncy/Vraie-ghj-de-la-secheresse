﻿namespace Model
{
    public class PlayerPerk
    {
        public enum PerkAction
        {
            CAC, DISTANCE,COUNTER,DASH,JUMP,PASSIVE,BONUS, NONE, DIEING,GET_SHIELD
        }
        public enum PerkType
        {
            CAC, DISTANCE,COUNTER,DASH,JUMP,PASSIVE,BONUS
        }
        public int CompetencePointCost { get; private set; }
        public PerkType Type { get; private set; }
        public bool isBucheron { get; private set; }

        public PlayerPerk(PerkType type, int competencePointCost, bool bucheron)
        {
            isBucheron = bucheron;
            Type = type;
            CompetencePointCost = competencePointCost;
        }
    }
}