using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPAssignment.Enums;
using OOPAssignment.Interfaces;
using OOPAssignment.Structs;

/* Thought about using if-else conditions instead of switch cases;
 * Then came across this article:
 * https://stackoverflow.com/questions/395618/is-there-any-significant-difference-between-using-if-else-and-switch-case-in-c
  */



namespace OOPAssignment.Classes
{
    public class Car : Interfaces.ICarCommand, Interfaces.IObservable<CarInfo>
    {

        public Car(Coordinates coordinates, Direction direction, ISurface surface)
        {
            Coordinates = coordinates;
            Direction = direction;
            Surface = surface;
        }
        public Guid Id
        {
            get; set;
        }

        public Coordinates Coordinates;

        public ISurface Surface;

        private Interfaces.IObserver<CarInfo> Observer { get; set; }

        public Direction Direction;

        public void Notify()
        {
            Observer.Update(new CarInfo(Id, Coordinates));
        }

        public void Attach(Interfaces.IObserver<CarInfo> observer)
        {
            Observer = observer;

            Notify();
        }

        public void Move()
        {
            switch (Direction)
            {
           
                case Direction.N:
                    Coordinates.Y++;
                    break;

                case Direction.S:
                    Coordinates.Y--;
                    break;

                case Direction.E:
                    Coordinates.X++;
                    break;

                case Direction.W:
                    Coordinates.X--;
                    break;

                default:
                    throw new Exception("Invalid ");
            }
            if (Surface.IsCoordinatesInBounds(Coordinates) == false)
            {
                throw new Exception();
            }
            
            Notify();


        }

        public void TurnLeft()
        {
            switch (Direction)
            {
                case Direction.N:
                    Direction = Direction.W;
                    break;

                case Direction.S:
                    Direction = Direction.E;
                    break;

                case Direction.E:
                    Direction = Direction.N;
                    break;

                case Direction.W:
                    Direction = Direction.S;
                    break;

                default:
                    throw new Exception("Invalid ");
            }

        }

        public void TurnRight()
        {
            switch (Direction)
            {
                case Direction.N:
                    Direction = Direction.E;
                    break;

                case Direction.S:
                    Direction = Direction.W;
                    break;

                case Direction.E:
                    Direction = Direction.S;
                    break;

                case Direction.W:
                    Direction = Direction.N;
                    break;

                default:
                    throw new Exception("Invalid ");
            }
        }

    }
    }
