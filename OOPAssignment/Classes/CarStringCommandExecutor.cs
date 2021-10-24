using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPAssignment.Interfaces;


namespace OOPAssignment.Classes
{
    public class CarStringCommandExecutor : CarCommandExecutorBase, IStringCommand
    {

        public CarStringCommandExecutor(ICarCommand carCommand) : base(carCommand)
        {
           
        }

        public void ExecuteCommand(string commandObject)
        {
            if (string.IsNullOrEmpty(commandObject))
            {
                throw new Exception();
            }

            foreach (char item in commandObject)
            {
                
                switch (item) {


                    case 'M':

                        CarCommand.Move();
                        break;

                    case 'L':

                        CarCommand.TurnLeft();
                        break;

                    case 'R':

                        CarCommand.TurnRight();
                        break;

                    default:

                        throw new Exception();

                }
            }

        }
    }
}