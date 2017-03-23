using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.IO;

namespace Fizzyo_Library
{
    public class FizzyoDevice : GameComponent
    {
        #region Fields

        //public 
        public bool useRecordedData = true;
        public bool loop = true;
        public string debugTextPressure = string.Empty;

        //protected
        protected string[] recordedData;
        private int recordedIndex = 0;
        protected StreamReader fileReader = null;
        protected string text = " ";

        InputState Input;
        float pollTimer = 0;
        int pollTimerInterval = 300;
        float pressure = 0;
        #endregion

        #region constructor/initialisation
        public FizzyoDevice (Game game): base (game)
        {
            // retrieve the Input manager
            Input = (InputState)Game.Services.GetService(
                typeof(InputState));
        }

#endregion

        #region Update
        /// <summary>
        /// Update the Fizzio Device system.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public override void Update(GameTime gameTime)
        {
            pollTimer += gameTime.ElapsedGameTime.Milliseconds;
            if (pollTimer > pollTimerInterval)
            {
                pollTimer = 0;
                PollLoggedData();
            }
            base.Update(gameTime);
        }
        #endregion

        #region Disposing
        /// <summary>
        /// Clean up the component when it is disposing.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
        #endregion

        #region public Functions

        // Use this for initialization
        public void LoadRecordedData(string[] input)
        {
            recordedData = input;
        }

        /// <summary>
        /// If useRecordedData is set to false pressure data is streamed from the device or streamed from a log file if set to true.
        /// </summary>
        /// <returns>pressure data reported from device or log file with a range of -1 - 1.</returns>
        public float Pressure()
        {
            if (useRecordedData)
            {
                if (debugTextPressure != null)
                {
                    debugTextPressure = String.Format("{0:0}", pressure * 100);
                }
                return pressure;
            }
            else
            {
                //Check Gamepad stick
                float p = Input.GetThumbStickLeft(0).X;
                //Check left arrow - decrease if pressed
                if (Input.IsKeyPressed(Keys.Left)) p--;
                //check right arrow - increase if pressed
                if (Input.IsKeyPressed(Keys.Right)) p++;

                //Update pressure text display
                debugTextPressure = String.Format("{0:0}", p * 100);

                return p;
            }
        }

        public bool ButtonDown()
        {
            return Input.PlayerPressedFire(0);
        }

        void PollLoggedData()
        {
            text = recordedData[recordedIndex];
            recordedIndex++;
            string[] parts = text.Split(' ');
            if (parts.Length == 2 && parts[0] == "v")
            {
                float pressure = float.Parse(parts[1], System.Globalization.CultureInfo.InvariantCulture.NumberFormat) / 100.0f;
                this.pressure = pressure;
            }
            if (loop && recordedIndex >= recordedData.Length)
            {
                recordedIndex = 0;
            }
        }
        #endregion

    }
}