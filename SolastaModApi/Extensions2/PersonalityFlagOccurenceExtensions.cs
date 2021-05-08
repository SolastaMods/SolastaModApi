namespace SolastaModApi
{
    /// <summary>
    /// Manually add value to auto generated extensions
    /// </summary>
    public static partial class PersonalityFlagOccurenceExtensions
    {
        public static PersonalityFlagOccurence Create(int weight, string personalityFlag)
        {
            var flag = new PersonalityFlagOccurence();

            flag.SetWeight(weight);
            flag.SetPersonalityFlag(personalityFlag);

            return flag;
        }
    }
}
