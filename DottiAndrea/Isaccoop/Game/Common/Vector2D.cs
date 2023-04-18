using System;

namespace Isaccoop.Game.Common 
{
    /// <summary>
    /// Class to model a vector into 2d space.
    /// </summary>
    public class Vector2D
    {
        /// <summary>
        /// Get the X of this <see cref="Vector2D"/>
        /// </summary>
        public double X { get; }

        /// <summary>
        /// Get the Y of this <see cref="Vector2D"/>
        /// </summary>
        public double Y { get; }

        /// <summary>
        /// Constructor for <see cref="Vector2D"/>.
        /// </summary>
        /// <param name = "x"> x coordinate</param> 
        /// <param name = "y"> y coordinate</param>
        public Vector2D(double x, double y) {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Constructor for <see cref="Vector2D"/> using the difference between two <see cref="Point2D"/>.
        /// </summary>
        /// <param name="to">destination point</param>
        /// <param name="from">origin point</param>
        public Vector2D(Point2D to, Point2D from) {
            X = to.X - from.X;
            Y = to.Y - from.Y;
        }

        /// <summary>
        /// Method to sum two <see cref="Vector2D"/>.
        /// </summary>
        /// <param name="v">vector to sum</param> v 
        /// <returns>sum between two <see cref="Vector2D"/></returns>
        public Vector2D Sum(Vector2D v) => new Vector2D(X + v.X, Y + v.Y);

        /// <summary>
        /// Method to compute the module of this <see cref="Vector2D"/>.
        /// </summary>
        /// <returns>module of this vector</returns> 
        public double Module() => Math.Sqrt(X * X + Y * Y);

        /// <summary>
        /// Method to normalize this <see cref="Vector2D"/>.
        /// </summary>
        /// <returns> normalized vector</returns>
        public Vector2D GetNormalized() {
            double module = Module();
            return new Vector2D(X / module, Y / module);
        }

        /// <summary>
        /// Method for multiplying the vector by a scalar number.
        /// </summary>
        /// <param name="fact">scalar number</param> 
        /// <returns> computed vector result</returns>
        public Vector2D Mul(double fact) => new Vector2D(X * fact, Y * fact);
    }
}
