using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MagusTools
{
    public class Character
    {
        public Character()
        {
        }

        public void userEvent_UpDownChanged(object sender, EventArgs e)
        {
            Console.WriteLine(((Control)sender).Name);
        }

        public void userEvent_ComboBoxChanged(object sender, EventArgs e)
        {
            Console.WriteLine(((Control)sender).Name);
        }

    }

    internal static class Stats
    {
        private static List<Stat> stats = new List<Stat>();
    }

    internal class Stat
    {
    }

    internal static class Weapons
    {
        private static List<Weapon> weapons = new List<Weapon>();
    }

    internal class Weapon
    { 
        public string Name { get; }
        public string Category { get; }
        public int Initiative { get; }
        public int Attack { get; }
        public int Defense { get; }
        public int Aim { get; }
        public int Range { get; }
        public int MinDamage { get; }
        public int MaxDamage { get; }
        public int BaseDamage { get; }
        public float AttackPerRound { get; }

        public string RequiredStatType { get; }
        public int RequiredStatValue { get; }
        public bool IsDoubleHanded { get; }

        public bool IsOwnedByCharacter { get; }
        public bool IsEquippedByCharacter { get; }

        /// <summary>
        /// Constructor for a melee weapon.
        /// </summary>
        public Weapon(string name, string category, int initiative, int attack_aim, int defense_range,
            int minDamage, int maxDamage, int baseDamage, float attackPerRound,
            string requiredStatType, int requiredStatValue, bool isDoubleHanded)
        {
            bool isRanged = category == "célzófegyver" || category == "tűzfegyver";

            Name = name;
            Category = category;
            Initiative = initiative;
            Attack = (isRanged) ? -1 : attack_aim;
            Defense = (isRanged) ? -1 : defense_range;
            Aim = (isRanged) ? attack_aim : -1;
            Range = (isRanged) ? defense_range : -1;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            BaseDamage = baseDamage;
            AttackPerRound = attackPerRound;
            RequiredStatType = requiredStatType;
            RequiredStatValue = requiredStatValue;
            IsDoubleHanded = isDoubleHanded;
        }
    }

    internal static class Armors
    {
        //private List<Armor> armors;
    }

    internal class Armor
    {
    }

    internal static class Items
    {
    }

    internal class Item
    {
    }

    internal static class Skills
    {
        private static List<Skill> skills = new List<Skill>();
    }

    internal class Skill
    {
    }
}