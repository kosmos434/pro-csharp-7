using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarLibrary
{
    // Enum.
    public enum EngineState
    {
        engineAlive, engineDead
    }

    // Which type of music player does this car have?
    public enum MusicMedia
    {
        musicCd,
        musicTape,
        musicRadio,
        musicMp3
    }

    public abstract class Car
    {
        // Fields.
        public string PetName { get; set; }
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }

        protected EngineState egnState = EngineState.engineAlive;
        public EngineState EngineState => egnState;

        // Methods.
        public abstract void TurboBoost();

        // enum, arrow function, string interpolation
        public void TurnOnRadio(bool musicOn, MusicMedia mm) 
            => MessageBox.Show(musicOn ? $"Jamming {mm}" : "Quiet time...");

        // Ctors.
        public Car() => MessageBox.Show("CarLibrary Version 2.0!");
        public Car(string name, int maxSp, int currSp)
        {
            MessageBox.Show("CarLibrary Version 2.0!");
            PetName = name; MaxSpeed = maxSp; CurrentSpeed = currSp;
        }
    }
}
