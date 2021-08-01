using System;

namespace lib
{
    public abstract class Character
    {
        public IWeapon weapon { get; set; }


        public Character(IWeapon weapon)
        {
            this.weapon = weapon;
        }

        public void Fight()
        {
            weapon.useWeapon();
        }
    }
}
