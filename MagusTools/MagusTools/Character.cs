using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MagusTools
{
    public class Character
    {

        public bool ChangeStat(object sender, int newValue)
        {
            MessageBox.Show((sender as Control).ToString());
            return false;
        }
    }

    internal static class Stats
    {
        // TODO: Change this to be loaded from an XML datafile and be localizable!

        // The list of primary stats.
        internal enum PrimaryStats { Strength, Speed, Agility, Endurance, Health, Charisma, Intelligence, Willpower, Astral, Perception }

        public static readonly string[] statNames = 
        // 00 - 09
        { "Strength", "Speed", "Agility", "Endurance", "Health", "Charisma", "Intelligence", "Willpower", "Astral", "Perception",
        // 10 - 13
          "Initiative", "Attack", "Defense", "Aim",
        // 14 - 18
          "Health Points", "Pain Resistance Points", "Psy Points", "Mana Points", "Ability Points",
        // 19 - 23
          "Combat Modifiers Per Level", "Pain Resistance Per Level", "Ability Points Per Level", "Psy Points Per Level", "Mana Per Level",
        // 24 - 27
          "Astral Resistance", "Mental Resistance", "Damage Bonus", "Psy Learnt Level",
        // 28 -
          "Level", "Age", "Race", "Class",""
        };

        private static List<Stat> stats = new List<Stat>();

        public static void Initialize()
        {
            foreach (var statName in statNames)
            {
                stats.Add(new Stat(statName, 0));
            }
        }

        public static int GetStat(string statName)
        {
            int statSearch = Array.IndexOf(statNames, statName);
            int result = 0;

            switch (statSearch)
            {
                // Get the value for Strength.
                case 0:
                // Get the value for Speed.
                case 1:
                // Get the value for Agility.
                case 2:

                    PrimaryStats currentStat;
                    if (statSearch == 0) currentStat = PrimaryStats.Strength;
                    else if (statSearch == 1) currentStat = PrimaryStats.Speed;
                    else currentStat = PrimaryStats.Agility;
                    
                    result +=
                    (
                        // Get an IEnumerable result from Skills.GetSkilsThatMatch() and Weapons.GetWeaponsWithStatReq()
                        // then compare the two list for Name == SubType matches. If there's any (Count > 0) return an
                        // incresed value. If there's none (Count <= 0), return the Stat's value unchanged.
                        Skills.GetSkilsThatMatch("Fegyverhasználat", "", 3, Skills.WeaponLevelCheck.GreaterOrEqualTo)
                            .Where(s => Weapons.GetWeaponsWithStatReq(currentStat)
                            .Any(w => w.Name == s.SubType))
                            .Count() > 0
                    ) ? stats[statSearch].Value + 1: stats[statSearch].Value;
                    break;

                // Get the value for Endurance.
                case 3:
                    result = stats[statSearch].Value;
                    break;
                // Get the value for Health.
                case 4:
                    result = stats[statSearch].Value;
                    break;
                // Get the value for Charisma.
                case 5:
                    result = stats[statSearch].Value;
                    break;
                // Get the value for Intelligence.
                case 6:
                    result = stats[statSearch].Value;
                    break;
                // Get the value for Willpower.
                case 7:
                    result = stats[statSearch].Value;
                    break;
                // Get the value for Astral.
                case 8:
                    result = stats[statSearch].Value;
                    break;
                // Get the value for Perception.
                case 9:
                    result = stats[statSearch].Value;
                    break;

                // Return -1, if no Stat matches the criteria.
                default:
                    result = -1;
                    break;
            }

            result += Stats.GetAgeModifier(statSearch);

            return result;
        }

        private static int GetAgeModifier(int statType)
        {
            switch (true)
            {
                default:
                    break;
            }
            return 0;
        }
    }

    internal class Stat
    {
        public string Name { get; }
        public int Value { get; }

        public Stat(string name, int value)
        {
            Name = name;
            Value = value;
        }
    }

    internal static class Weapons
    {
        // The list of possible weapon categories.
        internal enum WeaponCategory { Blade, Pierce, Blunt, Pole, Thrown, Ranged, Firearm, Other };

        // The list of possible weapon attacks per round.
        internal enum WeaponAttackPerRound { OneInFour, OneInThree, OneInTwo, OneInOne, TwoInOne, ThreeInOne, FourInOne }

        // The list of all available weapons.
        private static List<Weapon> weapons;

        public static bool IsWeaponEquipped(Weapon weapon)
        {
            return false;
        }

        public static IEnumerable<Weapon> GetWeaponsWithStatReq(Stats.PrimaryStats statReq)
        {
            // Return a list with the weapons that match the criteria.
            return weapons.Where(w => w.RequiredStatType == statReq);
        }
    }

    internal class Weapon
    { 
        public string Name { get; }
        public Weapons.WeaponCategory Category { get; }

        public int Initiative { get; }
        public int Attack { get; }
        public int Defense { get; }
        public int Aim { get; }
        public int Range { get; }
        public int MinDamage { get; }
        public int MaxDamage { get; }
        public int BaseDamage { get; }
        public Weapons.WeaponAttackPerRound AttackPerRound { get; }

        public Stats.PrimaryStats RequiredStatType { get; }
        public int RequiredStatValue { get; }
        public bool IsDoubleHanded { get; }

        public bool IsOwnedByCharacter { get; }
        public bool IsEquippedByCharacter { get; }

        /// <summary>
        /// Constructor for a melee weapon.
        /// </summary>
        public Weapon(string name, int initiative, int attack, int defense, int minDamage, int maxDamage, int baseDamage, Weapons.WeaponAttackPerRound attackPerRound, Stats.PrimaryStats requiredStatType, int requiredStatValue, bool isDoubleHanded)
        {
            Name = name;
            Initiative = initiative;
            Attack = attack;
            Defense = defense;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            BaseDamage = baseDamage;
            AttackPerRound = attackPerRound;
            RequiredStatType = requiredStatType;
            RequiredStatValue = requiredStatValue;
            IsDoubleHanded = isDoubleHanded;
        }

        /// <summary>
        /// Constructor for a ranged weapon.
        /// </summary>
        public Weapon(string name, int initiative, int aim, int range, int minDamage, int maxDamage, int baseDamage, Weapons.WeaponAttackPerRound attackPerRound, Stats.PrimaryStats requiredStatType, int requiredStatValue)
        {
            Name = name;
            Initiative = initiative;
            Aim = aim;
            Range = range;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            BaseDamage = baseDamage;
            AttackPerRound = attackPerRound;
            RequiredStatType = requiredStatType;
            RequiredStatValue = requiredStatValue;
            IsDoubleHanded = true;
        }
    }

    internal class Armors
    {
        private List<Armor> armors;
    }

    internal class Armor
    {
    }

    internal class Items
    {
        private List<Item> items;
    }

    internal class Item
    {
        //        // The list of all available armors and shields.
        //        internal static List<Armor> _Armors;

        //        // The list of all available items.
        //        internal static List<Item> _Items;

        //        // The list of all available skills.
        //        internal static List<Skill> _Skills;
    }

    internal static class Skills
    {
        internal enum WeaponLevelCheck { LessThan, LessOrEqualTo, EqualTo, GreaterOrEqualTo, GreaterThan }

        private static List<Skill> skills;

        public static IEnumerable<Skill> GetSkilsThatMatch(string skillName, string subType, int level, WeaponLevelCheck levelCheckType)
        {
            // Return a list with the weapons that match the criteria.
            switch (levelCheckType)
            {
                case WeaponLevelCheck.LessThan:
                    return skills.Where(s => s.Name == skillName && s.SubType == subType && s.Level < level);
                case WeaponLevelCheck.LessOrEqualTo:
                    return skills.Where(s => s.Name == skillName && s.SubType == subType && s.Level <= level);
                case WeaponLevelCheck.GreaterOrEqualTo:
                    return skills.Where(s => s.Name == skillName && s.SubType == subType && s.Level >= level);
                case WeaponLevelCheck.GreaterThan:
                    return skills.Where(s => s.Name == skillName && s.SubType == subType && s.Level > level);
                default:
                    return skills.Where(s => s.Name == skillName && s.SubType == subType && s.Level == level);
            }
        }
    }

    internal class Skill
    {
        public string Name { get; }
        public string SubType { get; }
        public int Level { get; }
        public List<Object> RequirementsLvlOne { get; }

    }
}