using System.Collections.Generic;
using System.Xml.Linq;

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
                    statList[(int)Stats.DamageBonus].Actual = statList[(int)Stats.DamageBonus].Base + 
                        System.Math.Max(statList[(int)stat].Actual - 16, 0) +
                        ((GetClass() == "Fejvadász") ? statList[(int)Stats.Level].Actual / 2 : 0);
                    statList[(int)Stats.Attack].Actual = statList[(int)Stats.Attack].Base + valueAboveTen;
                    break;
                case Stats.Speed:
                    statList[(int)Stats.Initiative].Actual = statList[(int)Stats.Initiative].Base + valueAboveTen;
                    statList[(int)Stats.Attack].Actual = statList[(int)Stats.Attack].Base + valueAboveTen;
                    statList[(int)Stats.Defense].Actual = statList[(int)Stats.Defense].Base + valueAboveTen;
                    break;
                case Stats.Agility:
                    statList[(int)stat].Actual += (IsSkillLearned(3, "Ügyesség") ? 1 : 0);
                    statList[(int)Stats.Initiative].Actual = statList[(int)Stats.Initiative].Base + valueAboveTen;
                    statList[(int)Stats.Attack].Actual = statList[(int)Stats.Attack].Base + valueAboveTen;
                    statList[(int)Stats.Defense].Actual = statList[(int)Stats.Defense].Base + valueAboveTen;
                    break;
                case Stats.Endurance:
                    statList[(int)Stats.PR].Actual = statList[(int)Stats.PR].Base +
                        System.Math.Max(statList[(int)Stats.Willpower].Actual - 10, 0) +
                        valueAboveTen;
                    break;
                case Stats.Health:
                    statList[(int)Stats.HP].Actual = statList[(int)Stats.HP].Base + valueAboveTen;
                    statList[(int)Stats.Resistance].Actual = valueAboveTen;
                    break;
                case Stats.Charisma:
                    break;
                case Stats.Intelligence:
                    if (GetClass() == "Bárd")
                        statList[(int)Stats.MP].Actual = statList[(int)Stats.Level].Actual * valueAboveTen;
                    if (IsSkillLearned("Pszi", 1))
                        statList[(int)Stats.Psy].Actual = valueAboveTen + statList[(int)Stats.Level].Actual * statList[(int)Stats.PsyperLevel].Actual;
                    break;
                case Stats.Willpower:
                    statList[(int)Stats.PR].Actual = statList[(int)Stats.PR].Base +
                        System.Math.Max(statList[(int)Stats.Endurance].Actual - 10, 0) +
                        valueAboveTen;
                    statList[(int)Stats.MMR].Actual = statList[(int)Stats.MMR].Base + valueAboveTen;
                    break;
                case Stats.Astral:
                    statList[(int)Stats.AMR].Actual = statList[(int)Stats.AMR].Base + valueAboveTen;
                    break;
                case Stats.Perception:
                    break;

                case Stats.Initiative:
                    statList[(int)stat].Actual += System.Math.Max(statList[(int)Stats.Speed].Base - 10, 0);
                    statList[(int)stat].Actual += System.Math.Max(statList[(int)Stats.Agility].Base - 10, 0);
                    break;
                case Stats.Attack:
                    statList[(int)stat].Actual += System.Math.Max(statList[(int)Stats.Strength].Base - 10, 0);
                    statList[(int)stat].Actual += System.Math.Max(statList[(int)Stats.Agility].Base - 10, 0);
                    statList[(int)stat].Actual += System.Math.Max(statList[(int)Stats.Speed].Base - 10, 0);
                    break;
                case Stats.Defense:
                    statList[(int)stat].Actual += System.Math.Max(statList[(int)Stats.Speed].Base - 10, 0);
                    statList[(int)stat].Actual += System.Math.Max(statList[(int)Stats.Agility].Base - 10, 0);
                    break;
                case Stats.Aim:
                    statList[(int)stat].Actual += System.Math.Max(statList[(int)Stats.Agility].Base - 10, 0);
                    break;
                case Stats.CMperLevel:
                    statList[(int)stat].Actual *= statList[(int)Stats.Level].Base;
                    break;
                case Stats.HP:
                    statList[(int)stat].Actual += System.Math.Max(statList[(int)Stats.Health].Base - 10, 0);
                    break;
                case Stats.PR:
                    statList[(int)stat].Actual += statList[(int)Stats.PRperLevel].Base * statList[(int)Stats.Level].Base;
                    statList[(int)stat].Actual += System.Math.Max(statList[(int)Stats.Endurance].Base - 10, 0);
                    statList[(int)stat].Actual += System.Math.Max(statList[(int)Stats.Willpower].Base - 10, 0);
                    break;
                case Stats.PRperLevel:
                    break;
                case Stats.KP:
                    statList[(int)stat].Actual += statList[(int)Stats.KPperLevel].Base * statList[(int)Stats.Level].Base;
                    statList[(int)stat].Actual -= GetSpentCcp();
                    break;
                case Stats.KPperLevel:
                    break;
                case Stats.Level:
                    statList[(int)Stats.CMperLevel].Actual *= statList[(int)Stats.CMperLevel].Base * newValue;
                    statList[(int)Stats.PRperLevel].Actual *= statList[(int)Stats.PRperLevel].Base * newValue;
                    statList[(int)Stats.KPperLevel].Actual *= statList[(int)Stats.KPperLevel].Base * newValue;
                    break;
                case Stats.DamageBonus:
                    break;
                case Stats.Resistance:
                    break;
                case Stats.AMR:
                    break;
                case Stats.MMR:
                    break;
                case Stats.MP:
                    break;
                case Stats.MPperLevel:
                    break;
                case Stats.Psy:
                    break;
                case Stats.PsyperLevel:
                    break;
                default:
                    break;
            }
        }

        public string GetClass()
        {
            return "KrumpliOrr";
            //return "Fejvadász";
        }

        public int GetSpentCcp()
        {
            return 0;
        }

        public bool IsSkillLearned(string skillName, int level)
        {
            return false;
            //return true;
        }

        public bool IsSkillLearned(int level, string subTypeReq)
        {
            return false;
            //return true;
        }

        private class Stat
        {
            public int Actual { get; set; }
            public int Base { get; set; }
        }
    }
}