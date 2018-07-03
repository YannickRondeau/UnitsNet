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
    ///     The heat transfer coefficient or film coefficient, or film effectiveness, in thermodynamics and in mechanics is the proportionality constant between the heat flux and the thermodynamic driving force for the flow of heat (i.e., the temperature difference, ΔT)
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart

    public partial struct HeatTransferCoefficient : IComparable, IComparable<HeatTransferCoefficient>
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        #region Nullable From Methods

        /// <summary>
        ///     Get nullable HeatTransferCoefficient from nullable WattsPerSquareMeterCelsius.
        /// </summary>
        public static HeatTransferCoefficient? FromWattsPerSquareMeterCelsius(QuantityValue? wattspersquaremetercelsius)
        {
            return wattspersquaremetercelsius.HasValue ? FromWattsPerSquareMeterCelsius(wattspersquaremetercelsius.Value) : default(HeatTransferCoefficient?);
        }

        /// <summary>
        ///     Get nullable HeatTransferCoefficient from nullable WattsPerSquareMeterKelvin.
        /// </summary>
        public static HeatTransferCoefficient? FromWattsPerSquareMeterKelvin(QuantityValue? wattspersquaremeterkelvin)
        {
            return wattspersquaremeterkelvin.HasValue ? FromWattsPerSquareMeterKelvin(wattspersquaremeterkelvin.Value) : default(HeatTransferCoefficient?);
        }

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="HeatTransferCoefficientUnit" /> to <see cref="HeatTransferCoefficient" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>HeatTransferCoefficient unit value.</returns>
        public static HeatTransferCoefficient? From(QuantityValue? value, HeatTransferCoefficientUnit fromUnit)
        {
            return value.HasValue ? new HeatTransferCoefficient((double)value.Value, fromUnit) : default(HeatTransferCoefficient?);
        }

        #endregion

        #region Arithmetic Operators

        public static HeatTransferCoefficient operator -(HeatTransferCoefficient right)
        {
            return new HeatTransferCoefficient(-right.Value, right.Unit);
        }

        public static HeatTransferCoefficient operator +(HeatTransferCoefficient left, HeatTransferCoefficient right)
        {
            return new HeatTransferCoefficient(left.Value + right.AsBaseNumericType(left.Unit), left.Unit);
        }

        public static HeatTransferCoefficient operator -(HeatTransferCoefficient left, HeatTransferCoefficient right)
        {
            return new HeatTransferCoefficient(left.Value - right.AsBaseNumericType(left.Unit), left.Unit);
        }

        public static HeatTransferCoefficient operator *(double left, HeatTransferCoefficient right)
        {
            return new HeatTransferCoefficient(left * right.Value, right.Unit);
        }

        public static HeatTransferCoefficient operator *(HeatTransferCoefficient left, double right)
        {
            return new HeatTransferCoefficient(left.Value * right, left.Unit);
        }

        public static HeatTransferCoefficient operator /(HeatTransferCoefficient left, double right)
        {
            return new HeatTransferCoefficient(left.Value / right, left.Unit);
        }

        public static double operator /(HeatTransferCoefficient left, HeatTransferCoefficient right)
        {
            return left.WattsPerSquareMeterKelvin / right.WattsPerSquareMeterKelvin;
        }

        #endregion

        public static bool operator <=(HeatTransferCoefficient left, HeatTransferCoefficient right)
        {
            return left.Value <= right.AsBaseNumericType(left.Unit);
        }

        public static bool operator >=(HeatTransferCoefficient left, HeatTransferCoefficient right)
        {
            return left.Value >= right.AsBaseNumericType(left.Unit);
        }

        public static bool operator <(HeatTransferCoefficient left, HeatTransferCoefficient right)
        {
            return left.Value < right.AsBaseNumericType(left.Unit);
        }

        public static bool operator >(HeatTransferCoefficient left, HeatTransferCoefficient right)
        {
            return left.Value > right.AsBaseNumericType(left.Unit);
        }

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public static bool operator ==(HeatTransferCoefficient left, HeatTransferCoefficient right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left.Value == right.AsBaseNumericType(left.Unit);
        }

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public static bool operator !=(HeatTransferCoefficient left, HeatTransferCoefficient right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left.Value != right.AsBaseNumericType(left.Unit);
        }
    }
}
