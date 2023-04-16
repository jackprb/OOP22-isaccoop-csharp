using System;

namespace Isaccoop.Model.Common {
	/// <summary>
	/// Point2D class to model a 2d point into the space.
	/// </summary>
	public class Point2D
	{
		/// <summary>
		/// Get the X of this <see cref="Point2D"/>
		/// </summary>
		public double X { get; }

		/// <summary>
		/// Get the Y of this <see cref="Point2D"/>
		/// </summary>
		public double Y { get; }

		/// <summary>
		/// Constructor for <see cref="Point2D"/>.
		/// </summary>
		/// <param name="x">x coordinate</param> 
		/// <param name="y">y  coordinate</param>
		public Point2D(double x, double y) {
			X = x;
			Y = y;
		}

		/// <summary>
		/// Method to increase the position of the point through a vector.
		/// </summary>
		/// <param name="v">vector object as <see cref="Vector2D"/></param> 
		/// <returns>updated <see cref="Point2D"/> object</returns> 
		public Point2D Sum(Vector2D v) => new Point2D(X + v.X, Y + v.Y);

		/// <summary>
		/// Method to compute the difference between two <see cref="Point2D"/>.
		/// </summary>
		/// <param name="v"> <see cref="Point2D"/> to compare with this</param>
		/// <returns>difference between two points as a <see cref="Vector2D"/></returns> 
		public Vector2D Sub(Point2D v) => new Vector2D(X - v.X, Y - v.Y);

		public override bool Equals(object obj) =>
				obj is Point2D d && X == d.X && Y == d.Y;

		public override int GetHashCode() => HashCode.Combine(X, Y);
	}
}
