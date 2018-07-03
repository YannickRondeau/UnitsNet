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
    ///     Heat flux is the flow of energy per unit of area per unit of time
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart

    public partial struct HeatFlux : IComparable, IComparable<HeatFlux>
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        #region Nullable From Methods

        /// <summary>
        ///     Get nullable HeatFlux from nullable BtusPerHourSquareFoot.
        /// </summary>
        public static HeatFlux? FromBtusPerHourSquareFoot(QuantityValue? btusperhoursquarefoot)
        {
            return btusperhoursquarefoot.HasValue ? FromBtusPerHourSquareFoot(btusperhoursquarefoot.Value) : default(HeatFlux?);
        }

        /// <summary>
        ///     Get nullable HeatFlux from nullable BtusPerMinuteSquareFoot.
        /// </summary>
        public static HeatFlux? FromBtusPerMinuteSquareFoot(QuantityValue? btusperminutesquarefoot)
        {
            return btusperminutesquarefoot.HasValue ? FromBtusPerMinuteSquareFoot(btusperminutesquarefoot.Value) : default(HeatFlux?);
        }

        /// <summary>
        ///     Get nullable HeatFlux from nullable BtusPerSecondSquareFoot.
        /// </summary>
        public static HeatFlux? FromBtusPerSecondSquareFoot(QuantityValue? btuspersecondsquarefoot)
        {
            return btuspersecondsquarefoot.HasValue ? FromBtusPerSecondSquareFoot(btuspersecondsquarefoot.Value) : default(HeatFlux?);
        }

        /// <summary>
        ///     Get nullable HeatFlux from nullable BtusPerSecondSquareInch.
        /// </summary>
        public static HeatFlux? FromBtusPerSecondSquareInch(QuantityValue? btuspersecondsquareinch)
        {
            return btuspersecondsquareinch.HasValue ? FromBtusPerSecondSquareInch(btuspersecondsquareinch.Value) : default(HeatFlux?);
        }

        /// <summary>
        ///     Get nullable HeatFlux from nullable CaloriesPerSecondSquareCentimeter.
        /// </summary>
        public static HeatFlux? FromCaloriesPerSecondSquareCentimeter(QuantityValue? caloriespersecondsquarecentimeter)
        {
            return caloriespersecondsquarecentimeter.HasValue ? FromCaloriesPerSecondSquareCentimeter(caloriespersecondsquarecentimeter.Value) : default(HeatFlux?);
        }

        /// <summary>
        ///     Get nullable HeatFlux from nullable CentiwattsPerSquareMeter.
        /// </summary>
        public static HeatFlux? FromCentiwattsPerSquareMeter(QuantityValue? centiwattspersquaremeter)
        {
            return centiwattspersquaremeter.HasValue ? FromCentiwattsPerSquareMeter(centiwattspersquaremeter.Value) : default(HeatFlux?);
        }

        /// <summary>
        ///     Get nullable HeatFlux from nullable DeciwattsPerSquareMeter.
        /// </summary>
        public static HeatFlux? FromDeciwattsPerSquareMeter(QuantityValue? deciwattspersquaremeter)
        {
            return deciwattspersquaremeter.HasValue ? FromDeciwattsPerSquareMeter(deciwattspersquaremeter.Value) : default(HeatFlux?);
        }

        /// <summary>
        ///     Get nullable HeatFlux from nullable KilocaloriesPerHourSquareMeter.
        /// </summary>
        public static HeatFlux? FromKilocaloriesPerHourSquareMeter(QuantityValue? kilocaloriesperhoursquaremeter)
        {
            return kilocaloriesperhoursquaremeter.HasValue ? FromKilocaloriesPerHourSquareMeter(kilocaloriesperhoursquaremeter.Value) : default(HeatFlux?);
        }

        /// <summary>
        ///     Get nullable HeatFlux from nullable KilocaloriesPerSecondSquareCentimeter.
        /// </summary>
        public static HeatFlux? FromKilocaloriesPerSecondSquareCentimeter(QuantityValue? kilocaloriespersecondsquarecentimeter)
        {
            return kilocaloriespersecondsquarecentimeter.HasValue ? FromKilocaloriesPerSecondSquareCentimeter(kilocaloriespersecondsquarecentimeter.Value) : default(HeatFlux?);
        }

        /// <summary>
        ///     Get nullable HeatFlux from nullable KilowattsPerSquareMeter.
        /// </summary>
        public static HeatFlux? FromKilowattsPerSquareMeter(QuantityValue? kilowattspersquaremeter)
        {
            return kilowattspersquaremeter.HasValue ? FromKilowattsPerSquareMeter(kilowattspersquaremeter.Value) : default(HeatFlux?);
        }

        /// <summary>
        ///     Get nullable HeatFlux from nullable MicrowattsPerSquareMeter.
        /// </summary>
        public static HeatFlux? FromMicrowattsPerSquareMeter(QuantityValue? microwattspersquaremeter)
        {
            return microwattspersquaremeter.HasValue ? FromMicrowattsPerSquareMeter(microwattspersquaremeter.Value) : default(HeatFlux?);
        }

        /// <summary>
        ///     Get nullable HeatFlux from nullable MilliwattsPerSquareMeter.
        /// </summary>
        public static HeatFlux? FromMilliwattsPerSquareMeter(QuantityValue? milliwattspersquaremeter)
        {
            return milliwattspersquaremeter.HasValue ? FromMilliwattsPerSquareMeter(milliwattspersquaremeter.Value) : default(HeatFlux?);
        }

        /// <summary>
        ///     Get nullable HeatFlux from nullable NanowattsPerSquareMeter.
        /// </summary>
        public static HeatFlux? FromNanowattsPerSquareMeter(QuantityValue? nanowattspersquaremeter)
        {
            return nanowattspersquaremeter.HasValue ? FromNanowattsPerSquareMeter(nanowattspersquaremeter.Value) : default(HeatFlux?);
        }

        /// <summary>
        ///     Get nullable HeatFlux from nullable WattsPerSquareFoot.
        /// </summary>
        public static HeatFlux? FromWattsPerSquareFoot(QuantityValue? wattspersquarefoot)
        {
            return wattspersquarefoot.HasValue ? FromWattsPerSquareFoot(wattspersquarefoot.Value) : default(HeatFlux?);
        }

        /// <summary>
        ///     Get nullable HeatFlux from nullable WattsPerSquareInch.
        /// </summary>
        public static HeatFlux? FromWattsPerSquareInch(QuantityValue? wattspersquareinch)
        {
            return wattspersquareinch.HasValue ? FromWattsPerSquareInch(wattspersquareinch.Value) : default(HeatFlux?);
        }

        /// <summary>
        ///     Get nullable HeatFlux from nullable WattsPerSquareMeter.
        /// </summary>
        public static HeatFlux? FromWattsPerSquareMeter(QuantityValue? wattspersquaremeter)
        {
            return wattspersquaremeter.HasValue ? FromWattsPerSquareMeter(wattspersquaremeter.Value) : default(HeatFlux?);
        }

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="HeatFluxUnit" /> to <see cref="HeatFlux" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>HeatFlux unit value.</returns>
        public static HeatFlux? From(QuantityValue? value, HeatFluxUnit fromUnit)
        {
            return value.HasValue ? new HeatFlux((double)value.Value, fromUnit) : default(HeatFlux?);
        }

        #endregion

        #region Arithmetic Operators

        public static HeatFlux operator -(HeatFlux right)
        {
            return new HeatFlux(-right.Value, right.Unit);
        }

        public static HeatFlux operator +(HeatFlux left, HeatFlux right)
        {
            return new HeatFlux(left.Value + right.AsBaseNumericType(left.Unit), left.Unit);
        }

        public static HeatFlux operator -(HeatFlux left, HeatFlux right)
        {
            return new HeatFlux(left.Value - right.AsBaseNumericType(left.Unit), left.Unit);
        }

        public static HeatFlux operator *(double left, HeatFlux right)
        {
            return new HeatFlux(left * right.Value, right.Unit);
        }

        public static HeatFlux operator *(HeatFlux left, double right)
        {
            return new HeatFlux(left.Value * right, left.Unit);
        }

        public static HeatFlux operator /(HeatFlux left, double right)
        {
            return new HeatFlux(left.Value / right, left.Unit);
        }

        public static double operator /(HeatFlux left, HeatFlux right)
        {
            return left.WattsPerSquareMeter / right.WattsPerSquareMeter;
        }

        #endregion

        public static bool operator <=(HeatFlux left, HeatFlux right)
        {
            return left.Value <= right.AsBaseNumericType(left.Unit);
        }

        public static bool operator >=(HeatFlux left, HeatFlux right)
        {
            return left.Value >= right.AsBaseNumericType(left.Unit);
        }

        public static bool operator <(HeatFlux left, HeatFlux right)
        {
            return left.Value < right.AsBaseNumericType(left.Unit);
        }

        public static bool operator >(HeatFlux left, HeatFlux right)
        {
            return left.Value > right.AsBaseNumericType(left.Unit);
        }

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public static bool operator ==(HeatFlux left, HeatFlux right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left.Value == right.AsBaseNumericType(left.Unit);
        }

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public static bool operator !=(HeatFlux left, HeatFlux right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left.Value != right.AsBaseNumericType(left.Unit);
        }
    }
}
