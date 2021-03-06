﻿/*
 *  Copyright (c) 2016 Rob Harwood <rob@codemlia.com>
 *  
 *  Permission is hereby granted, free of charge, to any person obtaining a copy of this software
 *  and associated documentation files (the "Software"), to deal in the Software without
 *  restriction, including without limitation the rights to use, copy, modify, merge, publish,
 *  distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the
 *  Software is furnished to do so, subject to the following conditions:
 *
 *  The above copyright notice and this permission notice shall be included in all copies or
 *  substantial portions of the Software.
 *
 *  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING
 *  BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 *  NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
 *  DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 *  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
 */
namespace Platformer.Engine
{
    /// <summary>
    /// Structure which represents a line.
    /// </summary>
    public struct Line
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Line"/> struct.
        /// </summary>
        /// <param name="start">The start point.</param>
        /// <param name="end">The end point.</param>
        public Line(Point start, Point end)
        {
            Start = start;
            End = end;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Line"/> struct.
        /// </summary>
        /// <param name="startX">The start x point.</param>
        /// <param name="startY">The start y point.</param>
        /// <param name="endX">The end x point.</param>
        /// <param name="endY">The end y point.</param>
        public Line(double startX, double startY, double endX, double endY)
        {
            Start = new Point(startX, startY);
            End = new Point(endX, endY);
        }

        /// <summary>
        /// Gets or sets the start.
        /// </summary>
        public Point Start { get; set; }

        /// <summary>
        /// Gets or sets the end.
        /// </summary>
        public Point End { get; set; }
    }
}
