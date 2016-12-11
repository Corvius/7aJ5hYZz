using System.Collections.Generic;
using System.Drawing;
using System.Xml.Linq;

namespace MagusTools
{
    public class Character
    {
        private enum Options { TripleCcp, FreeCharisma };
        private HashSet<Options> OptionFlags = new HashSet<Options>();
        private string charClass = "";

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

        private int ValueAbove(Stats stat, int threshold)
        {
            return System.Math.Max(statList[(int)stat].Actual - threshold, 0);
        }

        public void SetStat(Stats stat, int newValue)
        {
            Program.eventLogger.Log(new object[] { "Changing ", Color.Blue, stat.ToString(), Color.Black, " to the value ", Color.Cyan, newValue } );

            if (newValue < 0) return; // You Shall Not Pass!

            statList[(int)stat].Base = newValue;
            statList[(int)stat].Actual = newValue;

            switch (stat)
            {
                case Stats.Strength:
                    statList[(int)stat].Actual += (IsSkillLearned(3, "Erő") ? 1 : 0);
                    statList[(int)Stats.DamageBonus].Actual =
                        statList[(int)Stats.DamageBonus].Base + 
                        ValueAbove(stat, 16) +
                        ((GetClass() == "Fejvadász") ? statList[(int)Stats.Level].Actual / 2 : 0);
                    statList[(int)Stats.Attack].Actual =
                        statList[(int)Stats.Attack].Base +
                        ValueAbove(stat, 10) +
                        ValueAbove(Stats.Agility, 10) +
                        ValueAbove(Stats.Speed, 10);
                    break;
                case Stats.Speed:
                    statList[(int)Stats.Initiative].Actual =
                        statList[(int)Stats.Initiative].Base +
                        ValueAbove(stat, 10) +
                        ValueAbove(Stats.Agility, 10);
                statList[(int)Stats.Attack].Actual = 
                        statList[(int)Stats.Attack].Base + 
                        ValueAbove(stat, 10) +
                        ValueAbove(Stats.Agility, 10) +
                        ValueAbove(Stats.Strength, 10);
                    statList[(int)Stats.Defense].Actual =
                        statList[(int)Stats.Defense].Base +
                        ValueAbove(stat, 10) +
                        ValueAbove(Stats.Agility, 10);
                    break;
                case Stats.Agility:
                    statList[(int)stat].Actual += (IsSkillLearned(3, "Ügyesség") ? 1 : 0);
                    statList[(int)Stats.Initiative].Actual =
                        statList[(int)Stats.Initiative].Base +
                        ValueAbove(stat, 10) +
                        ValueAbove(Stats.Speed, 10);
                    statList[(int)Stats.Attack].Actual =
                            statList[(int)Stats.Attack].Base +
                            ValueAbove(stat, 10) +
                            ValueAbove(Stats.Speed, 10) +
                            ValueAbove(Stats.Strength, 10);
                    statList[(int)Stats.Defense].Actual =
                        statList[(int)Stats.Defense].Base +
                        ValueAbove(stat, 10) +
                        ValueAbove(Stats.Speed, 10);
                    statList[(int)Stats.Aim].Actual =
                        statList[(int)Stats.Aim].Base +
                        ValueAbove(stat, 10);
                    break;
                case Stats.Endurance:
                    statList[(int)Stats.PR].Actual =
                        statList[(int)Stats.PR].Base +
                        ValueAbove(stat, 10) +
                        ValueAbove(Stats.Willpower, 10);
                    break;
                case Stats.Health:
                    statList[(int)Stats.HP].Actual =
                        ValueAbove(stat, 10) +
                        statList[(int)Stats.HP].Base;
                    statList[(int)Stats.Resistance].Actual =
                        ValueAbove(stat, 10);
                    break;
                case Stats.Charisma:
                    break;
                case Stats.Intelligence:
                    if (GetClass() == "Bárd")
                        statList[(int)Stats.MP].Actual =
                            ValueAbove(stat, 10) * statList[(int)Stats.Level].Actual;
                    if (IsSkillLearned("Pszi", 1))
                        statList[(int)Stats.Psy].Actual =
                            ValueAbove(stat, 10) +
                            statList[(int)Stats.Level].Actual * statList[(int)Stats.PsyperLevel].Actual;
                    break;
                case Stats.Willpower:
                    statList[(int)Stats.PR].Actual =
                        statList[(int)Stats.PR].Base +
                        ValueAbove(stat, 10) +
                        ValueAbove(Stats.Endurance, 10);
                    statList[(int)Stats.MMR].Actual =
                        statList[(int)Stats.MMR].Base +
                        ValueAbove(stat, 10);
                    break;
                case Stats.Astral:
                    statList[(int)Stats.AMR].Actual =
                        statList[(int)Stats.AMR].Base +
                        ValueAbove(stat, 10);
                    break;
                case Stats.Perception:
                    break;

                case Stats.Initiative:
                    statList[(int)stat].Actual += ValueAbove(Stats.Speed, 10);
                    statList[(int)stat].Actual += ValueAbove(Stats.Agility, 10);
                    break;
                case Stats.Attack:
                    statList[(int)stat].Actual += ValueAbove(Stats.Strength, 10);
                    statList[(int)stat].Actual += ValueAbove(Stats.Agility, 10);
                    statList[(int)stat].Actual += ValueAbove(Stats.Speed, 10);
                    break;
                case Stats.Defense:
                    statList[(int)stat].Actual += ValueAbove(Stats.Speed, 10);
                    statList[(int)stat].Actual += ValueAbove(Stats.Agility, 10);
                    break;
                case Stats.Aim:
                    statList[(int)stat].Actual += ValueAbove(Stats.Agility, 10);
                    break;
                case Stats.CMperLevel:
                    statList[(int)stat].Actual *= statList[(int)Stats.Level].Base;
                    break;
                case Stats.HP:
                    statList[(int)stat].Actual += ValueAbove(Stats.Health, 10);
                    break;
                case Stats.PR:
                    statList[(int)stat].Actual += statList[(int)Stats.PRperLevel].Base * statList[(int)Stats.Level].Base;
                    statList[(int)stat].Actual += ValueAbove(Stats.Endurance, 10);
                    statList[(int)stat].Actual += ValueAbove(Stats.Willpower, 10);
                    break;
                case Stats.PRperLevel:
                    statList[(int)Stats.PR].Actual =
                        statList[(int)Stats.PR].Base +
                        statList[(int)stat].Base * statList[(int)Stats.Level].Base +
                        ValueAbove(Stats.Endurance, 10) +
                        ValueAbove(Stats.Willpower, 10);
                    break;
                case Stats.KP:
                    statList[(int)stat].Actual += 
                        statList[(int)Stats.KPperLevel].Base * statList[(int)Stats.Level].Base;
                    statList[(int)stat].Actual -= GetSpentKP();
                    break;
                case Stats.KPperLevel:
                    statList[(int)Stats.KP].Actual =
                        statList[(int)Stats.KP].Base +
                        statList[(int)stat].Base * statList[(int)Stats.Level].Base;
                    break;
                case Stats.Level:
                    statList[(int)Stats.CMperLevel].Actual = statList[(int)Stats.CMperLevel].Base * newValue;
                    statList[(int)Stats.PRperLevel].Actual = statList[(int)Stats.PRperLevel].Base * newValue;
                    statList[(int)Stats.KPperLevel].Actual = statList[(int)Stats.KPperLevel].Base * newValue;
                    statList[(int)Stats.PR].Actual =
                        statList[(int)Stats.PR].Base +
                        statList[(int)Stats.PRperLevel].Base * statList[(int)Stats.Level].Base +
                        ValueAbove(Stats.Endurance, 10) +
                        ValueAbove(Stats.Willpower, 10);
                    statList[(int)Stats.KP].Actual =
                        statList[(int)Stats.KP].Base +
                        statList[(int)Stats.KPperLevel].Base * statList[(int)Stats.Level].Base;
                        
                    if (OptionFlags.Contains(Options.TripleCcp))
                        statList[(int)Stats.KP].Actual *= 3;
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
            return charClass;
        }

        public void ChangeClass(string newClass)
        {
            if (newClass != string.Empty)
                charClass = newClass;
        }

        public void ChangeRace(string newRace)
        {
            // TODO: Update stats based on race's modifiers
        }

        public int GetSpentKP()
        {
            // TODO: Get the KP value of all Learned Skills
            return 0;
        }

        public List<object> GetSelectedSkills()
        {
            // TODO: Return a list of Learned Skills
            return null;
        }
        public void AddSelectedSkill(Skill newSkill)
        {
            // TODO: Add a new skill to Learned Skills list and
            //       update any stats if neccesary
        }

        // TODO: Add skill removing logic

        public bool IsSkillLearned(string skillName, int level)
        {
            // TODO: Check for existing skill by name and level
            return false;
            //return true;
        }

        public bool IsSkillLearned(int level, string subTypeReq)
        {
            // TODO: Check for existing skill by level and subtype requirement
            //       (this method is for determining weapon bonuses with certain skills)
            return false;
            //return true;
        }

        private class Stat
        {
            public int Actual { get; set; }
            public int Base { get; set; }
        }

        // TODO: Get a better Skill class,
        //       Figure out a way to keep this private
        public class Skill
        {
            public string Name { get; set; }
            public string SubType { get; set; }
            public int Level { get; set; }
            public int Cost { get; set; }
            public bool IsPurchasedWithCCP { get; set; }
        }
    }
}