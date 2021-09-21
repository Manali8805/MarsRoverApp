using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverApp.BAL
{

    public enum Directions
    {
        N = 1, //=== North Direction
        S = 2, //=== South Direction
        E = 3, //=== East Direction
        W = 4 //=== West Direction
    }

    public interface IRoverPosition
    {
        string StartMoving(List<int> maxPoints, string moves);
    }

    public class RoverPosition : IRoverPosition
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Directions Direction { get; set; }

        public RoverPosition()
        {
            X = 0; Y = 0;
            Direction = Directions.N;
        }

        public string StartMoving(List<int> maxPoints, string moveOrder)
        {
            try
            {
                foreach (var move in moveOrder)
                {
                    switch (move)
                    {
                        case 'M':
                            this.moveInSameDirection();
                            break;
                        case 'L':
                            this.rotateLeft();
                            break;
                        case 'R':
                            this.rotateRight();
                            break;
                        default:
                            throw new Exception(String.Format("Invalid Character {0}", move));
                    }

                    if (this.X < 0 || this.X > maxPoints[0] || this.Y < 0 || this.Y > maxPoints[1])
                    {
                        throw new Exception("Max. limit for position is reached. Rover cannot move further.");
                    }
                }

                return String.Format("{0} {1} {2}", this.X, this.Y, this.Direction);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void rotateRight()
        {
            try
            {
                switch (this.Direction)
                {
                    case Directions.N:
                        this.Direction = Directions.E;
                        break;
                    case Directions.S:
                        this.Direction = Directions.W;
                        break;
                    case Directions.E:
                        this.Direction = Directions.S;
                        break;
                    case Directions.W:
                        this.Direction = Directions.N;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error while moving in right direction!!");
            }

        }

        private void rotateLeft()
        {
            try
            {
                switch (this.Direction)
                {
                    case Directions.N:
                        this.Direction = Directions.W;
                        break;
                    case Directions.S:
                        this.Direction = Directions.E;
                        break;
                    case Directions.E:
                        this.Direction = Directions.N;
                        break;
                    case Directions.W:
                        this.Direction = Directions.S;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error while moving in left direction!!");
            }
        }

        private void moveInSameDirection()
        {

            //======= as campass direction is north--> east-->south-->west , logic is as below
            //==== north & south will deal with y poistion & east & west will deal with x position
            try
            {
                switch (this.Direction)
                {
                    case Directions.N:
                        this.Y += 1;
                        break;
                    case Directions.S:
                        this.Y -= 1;
                        break;
                    case Directions.E:
                        this.X += 1;
                        break;
                    case Directions.W:
                        this.X -= 1;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error while moving same direction!!");
            }
        }
    }
}
