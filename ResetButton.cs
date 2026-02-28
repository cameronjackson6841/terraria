using Terraria.ModLoader;

namespace ResetButtonMod
{
    public class ResetButton : Mod
    {
        public override void Load()
        {
            // Load your mod content here
        }

        // This can be added for the Time Shifter class
        public class TimeShifter
        {
            public void ShiftTime(int hours)
            {
                // Logic to shift time
            }
        }
    }
}