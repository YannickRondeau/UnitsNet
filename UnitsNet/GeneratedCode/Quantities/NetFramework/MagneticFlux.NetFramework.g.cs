﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add Extensions\MyQuantityExtensions.cs to decorate quantities with new behavior.
//     Add UnitDefinitions\MyQuantity.json and run GeneratUnits.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com).
// https://github.com/angularsen/UnitsNet
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Linq;
using JetBrains.Annotations;
using UnitsNet.Units;

// ReSharper disable once CheckNamespace

namespace UnitsNet
{
    /// <summary>
    ///     In physics, specifically electromagnetism, the magnetic flux through a surface is the surface integral of the normal component of the magnetic field B passing through that surface.
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart

    public partial struct MagneticFlux : IComparable, IComparable<MagneticFlux>
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        #region Nullable From Methods

        /// <summary>
        ///     Get nullable MagneticFlux from nullable Webers.
        /// </summary>
        public static MagneticFlux? FromWebers(QuantityValue? webers)
        {
            return webers.HasValue ? FromWebers(webers.Value) : default(MagneticFlux?);
        }

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="MagneticFluxUnit" /> to <see cref="MagneticFlux" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>MagneticFlux unit value.</returns>
        public static MagneticFlux? From(QuantityValue? value, MagneticFluxUnit fromUnit)
        {
            return value.HasValue ? new MagneticFlux((double)value.Value, fromUnit) : default(MagneticFlux?);
        }

        #endregion

        #region Arithmetic Operators

        public static MagneticFlux operator -(MagneticFlux right)
        {
            return new MagneticFlux(-right.Value, right.Unit);
        }

        public static MagneticFlux operator +(MagneticFlux left, MagneticFlux right)
        {
            return new MagneticFlux(left.Value + right.AsBaseNumericType(left.Unit), left.Unit);
        }

        public static MagneticFlux operator -(MagneticFlux left, MagneticFlux right)
        {
            return new MagneticFlux(left.Value - right.AsBaseNumericType(left.Unit), left.Unit);
        }

        public static MagneticFlux operator *(double left, MagneticFlux right)
        {
            return new MagneticFlux(left * right.Value, right.Unit);
        }

        public static MagneticFlux operator *(MagneticFlux left, double right)
        {
            return new MagneticFlux(left.Value * right, left.Unit);
        }

        public static MagneticFlux operator /(MagneticFlux left, double right)
        {
            return new MagneticFlux(left.Value / right, left.Unit);
        }

        public static double operator /(MagneticFlux left, MagneticFlux right)
        {
            return left.Webers / right.Webers;
        }

        #endregion

        public static bool operator <=(MagneticFlux left, MagneticFlux right)
        {
            return left.Value <= right.AsBaseNumericType(left.Unit);
        }

        public static bool operator >=(MagneticFlux left, MagneticFlux right)
        {
            return left.Value >= right.AsBaseNumericType(left.Unit);
        }

        public static bool operator <(MagneticFlux left, MagneticFlux right)
        {
            return left.Value < right.AsBaseNumericType(left.Unit);
        }

        public static bool operator >(MagneticFlux left, MagneticFlux right)
        {
            return left.Value > right.AsBaseNumericType(left.Unit);
        }

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public static bool operator ==(MagneticFlux left, MagneticFlux right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left.Value == right.AsBaseNumericType(left.Unit);
        }

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public static bool operator !=(MagneticFlux left, MagneticFlux right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left.Value != right.AsBaseNumericType(left.Unit);
        }
    }
}
