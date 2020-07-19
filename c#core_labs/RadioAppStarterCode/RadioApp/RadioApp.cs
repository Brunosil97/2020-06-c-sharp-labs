using System;


namespace RadioApp
{
    public class Radio
    {
        private int _channel = 1;
        private bool _on = false;

        public int Channel 
        {
          get { return _channel; } 
          set { if ((value < 5 && value > 0) && (_on == true)) _channel = value; }
        }

        public string Play()
        {
            string playChannel = "";

            if(_on == true)
            {
                
                playChannel += $"Playing channel {_channel}";
            }
            else 
            {
                playChannel += "Radio is off";
            }

            return playChannel;
        }

        public void TurnOff()
        {
            _on = false;
        }

        public void TurnOn()
        {
            _on = true;
        }

    }
    // implement a class Radio that corresponds to the Class diagram 
    //   and specification in the Radio_Mini_Project document
}