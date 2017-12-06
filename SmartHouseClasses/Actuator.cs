using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic;

namespace Domain
{ 
    public abstract class Actuator : Entity
    {
        public abstract void DoCommand(string command);
        public abstract string[] GetAllCommands();
    }
    public class Device : Actuator,ISwitcher
    {
        private string[] commands;
        private int lightPower;

        public Device(params string[] commands)
        {
            this.commands = commands;
        }

        public override void DoCommand(string command)
        {
            
        }
        public override string[] GetAllCommands()
        {
            return commands;
        }

        public void SwitchOff()
        {
            
        }
        public void SwitchOn()
        {
            
        }
    }
    public class Device2 : Actuator, ISwitcher,IDimmer,IChannel,ILock//TV
    {
        private string[] commands;
        private int lightPower;
        private int degree;
        private bool isLocked=false;

        public Device2(params string[] commands)
        {
            this.commands = commands;
        }

        public override void DoCommand(string command)
        {

        }
        public override string[] GetAllCommands()
        {
            return commands;
        }

        public int GetDegree()
        {
            return degree;
        }

        public void Lock(bool state)
        {
            this.isLocked = state;
        }

        public void Lower()
        {
            
        }

        public void Next()
        {
          
        }

        public void Previous()
        {
           
        }

        public void SetChannel(int channel)
        {
            
        }

        public void SetDegree(int value)
        {
            
        }

        public void SwitchOff()
        {

        }
        public void SwitchOn()
        {

        }

        public void Upper()
        {
            
        }
    }
    /*
     Телек-dimmer+switcher+locker+channel;
     Лампочка-dimmer+switcher;
     
     */
}