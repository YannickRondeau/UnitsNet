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
    ///     A temperature is a numerical measure of hot or cold. Its measurement is by detection of heat radiation or particle velocity or kinetic energy, or by the bulk behavior of a thermometric material. It may be calibrated in any of various temperature scales, Celsius, Fahrenheit, Kelvin, etc. The fundamental physical definition of temperature is provided by thermodynamics.
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart

    public partial struct Temperature : IComparable, IComparable<Temperature>
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        #region Nullable From Methods

        /// <summary>
        ///     Get nullable Temperature from nullable DegreesCelsius.
        /// </summary>
        public static Temperature? FromDegreesCelsius(QuantityValue? degreescelsius)
        {
            return degreescelsius.HasValue ? FromDegreesCelsius(degreescelsius.Value) : default(Temperature?);
        }

        /// <summary>
        ///     Get nullable Temperature from nullable DegreesDelisle.
        /// </summary>
        public static Temperature? FromDegreesDelisle(QuantityValue? degreesdelisle)
        {
            return degreesdelisle.HasValue ? FromDegreesDelisle(degreesdelisle.Value) : default(Temperature?);
        }

        /// <summary>
        ///     Get nullable Temperature from nullable DegreesFahrenheit.
        /// </summary>
        public static Temperature? FromDegreesFahrenheit(QuantityValue? degreesfahrenheit)
        {
            return degreesfahrenheit.HasValue ? FromDegreesFahrenheit(degreesfahrenheit.Value) : default(Temperature?);
        }

        /// <summary>
        ///     Get nullable Temperature from nullable DegreesNewton.
        /// </summary>
        public static Temperature? FromDegreesNewton(QuantityValue? degreesnewton)
        {
            return degreesnewton.HasValue ? FromDegreesNewton(degreesnewton.Value) : default(Temperature?);
        }

        /// <summary>
        ///     Get nullable Temperature from nullable DegreesRankine.
        /// </summary>
        public static Temperature? FromDegreesRankine(QuantityValue? degreesrankine)
        {
            return degreesrankine.HasValue ? FromDegreesRankine(degreesrankine.Value) : default(Temperature?);
        }

        /// <summary>
        ///     Get nullable Temperature from nullable DegreesReaumur.
        /// </summary>
        public static Temperature? FromDegreesReaumur(QuantityValue? degreesreaumur)
        {
            return degreesreaumur.HasValue ? FromDegreesReaumur(degreesreaumur.Value) : default(Temperature?);
        }

        /// <summary>
        ///     Get nullable Temperature from nullable DegreesRoemer.
        /// </summary>
        public static Temperature? FromDegreesRoemer(QuantityValue? degreesroemer)
        {
            return degreesroemer.HasValue ? FromDegreesRoemer(degreesroemer.Value) : default(Temperature?);
        }

        /// <summary>
        ///     Get nullable Temperature from nullable Kelvins.
        /// </summary>
        public static Temperature? FromKelvins(QuantityValue? kelvins)
        {
            return kelvins.HasValue ? FromKelvins(kelvins.Value) : default(Temperature?);
        }

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="TemperatureUnit" /> to <see cref="Temperature" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>Temperature unit value.</returns>
        public static Temperature? From(QuantityValue? value, TemperatureUnit fromUnit)
        {
            return value.HasValue ? new Temperature((double)value.Value, fromUnit) : default(Temperature?);
        }

        #endregion

        public static bool operator <=(Temperature left, Temperature right)
        {
            return left.Value <= right.AsBaseNumericType(left.Unit);
        }

        public static bool operator >=(Temperature left, Temperature right)
        {
            return left.Value >= right.AsBaseNumericType(left.Unit);
        }

        public static bool operator <(Temperature left, Temperature right)
        {
            return left.Value < right.AsBaseNumericType(left.Unit);
        }

        public static bool operator >(Temperature left, Temperature right)
        {
            return left.Value > right.AsBaseNumericType(left.Unit);
        }

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public static bool operator ==(Temperature left, Temperature right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left.Value == right.AsBaseNumericType(left.Unit);
        }

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public static bool operator !=(Temperature left, Temperature right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left.Value != right.AsBaseNumericType(left.Unit);
        }
    }
}
