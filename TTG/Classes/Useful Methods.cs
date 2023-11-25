using System.Collections.Generic;

namespace TTG.Classes
{
    public static class UsefulMethods
    {
        public static bool HasCircleReachedEnd(List<Entity> entities)
        {

            foreach (Entity entity in entities)
            {
                if (entity.Hitbox._position.X - entity.Hitbox._radius <= 160)
                {
                    return true;
                }
            }
            return false;
        }
        public static List<Entity> ToEntity(List<MeleeZombie> list)
        {
            List<Entity> entities = new List<Entity>();
            foreach (MeleeZombie melee in list)
            {
                entities.Add(melee);
            }
            return entities;
        }
        public static List<Entity> ToEntity(List<RangedZombie> list)
        {
            List<Entity> entities = new List<Entity>();
            foreach (RangedZombie melee in list)
            {
                entities.Add(melee);
            }
            return entities;
        }
        public static List<Entity> Join(List<RangedZombie> r, List<MeleeZombie> m)
        {
            List<Entity> list1 = ToEntity(r);
            List<Entity> list2 = ToEntity(m);
            foreach (Entity entity in list1)
            {
                list2.Add(entity);
            }
            return list2;
        }
    }
}
