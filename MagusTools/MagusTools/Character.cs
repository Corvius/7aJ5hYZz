using System.Collections.Generic;

namespace MagusTools
{
    public class Character
    {
        public enum Stats
        {
            Strength, Speed, Agility, Endurance, Health, Charisma, Intelligence, Willpower, Astral, Perception, 
            Initiative, Attack, Defense, Aim, CMperLevel, HP, PR, PRperLevel, KP, KPperLevel,
            Level, DamageBonus, Resistance, AMR, MMR, MP, MPperLevel, Psy, PsyperLevel
        }

        private List<Stat> statList = new List<Stat>();

        public Character()
        {
            foreach (var item in System.Enum.GetValues(typeof(Stats)))
            {
                statList.Add(new Stat() { Actual = 0, Base = 0 });
            }
        }

        public int GetStat(Stats stat)
        {
            return statList[(int)stat].Actual;
        }

        public void SetStat(Stats stat, int newValue)
        {
            if (newValue < 0) return; // You Shall Not Pass!

            statList[(int)stat].Base = newValue;
            statList[(int)stat].Actual = newValue;

            int valueAboveTen = System.Math.Max(newValue - 10, 0);

            switch (stat)
            {
                case Stats.Strength:
                    statList[(int)stat].Actual += (IsSkillLearned(3, "Erő") ? 1 : 0);
                    statList[(int)Stats.DamageBonus].Actual += 
                        System.Math.Max(statList[(int)stat].Actual - 16, 0) +
                        ((GetClass() == "Fejvadász") ? statList[(int)Stats.Level].Base / 2 : 0);
                    statList[(int)Stats.Attack].Actual += valueAboveTen;
                    break;
                case Stats.Speed:
                    statList[(int)Stats.Initiative].Actual += valueAboveTen; // TODO: Extend this to Ügyesség! (and fix the rest)
                    statList[(int)Stats.Attack].Actual += valueAboveTen;
                    statList[(int)Stats.Defense].Actual += valueAboveTen;
                    break;
                case Stats.Agility:
                    statList[(int)stat].Actual += (IsSkillLearned(3, "Ügyesség") ? 1 : 0);
                    statList[(int)Stats.Initiative].Actual += valueAboveTen;
                    statList[(int)Stats.Attack].Actual += valueAboveTen;
                    statList[(int)Stats.Defense].Actual += valueAboveTen;
                    break;
                case Stats.Endurance:
                    statList[(int)Stats.PR].Actual = valueAboveTen;
                    break;
                case Stats.Health:
                    statList[(int)Stats.HP].Actual += valueAboveTen;
                    statList[(int)Stats.Resistance].Actual = valueAboveTen;
                    break;
                case Stats.Charisma:
                    break;
                case Stats.Intelligence:
                    statList[(int)Stats.MP].Actual += ((GetClass() == "Bárd") ? valueAboveTen : 0);
                    statList[(int)Stats.Psy].Actual += (IsSkillLearned("Pszi", 1) ? valueAboveTen : 0);
                    break;
                case Stats.Willpower:
                    statList[(int)Stats.PR].Actual += valueAboveTen;
                    statList[(int)Stats.MMR].Actual += valueAboveTen;
                    break;
                case Stats.Astral:
                    statList[(int)Stats.AMR].Actual += valueAboveTen;
                    break;
                case Stats.Perception:
                    break;

                case Stats.Initiative:
                    statList[(int)stat].Actual +=
                        System.Math.Max(statList[(int)Stats.Speed].Base - 10, 0);
                    break;
                case Stats.Attack:
                    break;
                case Stats.Defense:
                    break;
                case Stats.Aim:
                    break;
                case Stats.CMperLevel:
                    break;
                case Stats.HP:
                    break;
                case Stats.PR:
                    break;
                case Stats.PRperLevel:
                    break;
                case Stats.KP:
                    break;
                case Stats.KPperLevel:
                    break;
                case Stats.Level:
                    break;
                default:
                    break;
            }
        }

        public string GetClass()
        {
            return "Fejvadász";
        }

        public bool IsSkillLearned(string skillName, int level)
        {
            return true;
        }

        public bool IsSkillLearned(int level, string subTypeReq)
        {
            return true;
        }

        private class Stat
        {
            public int Actual { get; set; }
            public int Base { get; set; }
        }
    }
}