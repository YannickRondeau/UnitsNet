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

// Windows Runtime Component does not support extension methods and method overloads: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
namespace UnitsNet.Extensions.NumberToElectricResistance
{
    public static class NumberToElectricResistanceExtensions
    {
        #region Kiloohm

        /// <inheritdoc cref="ElectricResistance.FromKiloohms(UnitsNet.QuantityValue)" />
        public static ElectricResistance Kiloohms(this int value) => ElectricResistance.FromKiloohms(value);

        /// <inheritdoc cref="ElectricResistance.FromKiloohms(UnitsNet.QuantityValue)" />
        public static ElectricResistance? Kiloohms(this int? value) => ElectricResistance.FromKiloohms(value);

        /// <inheritdoc cref="ElectricResistance.FromKiloohms(UnitsNet.QuantityValue)" />
        public static ElectricResistance Kiloohms(this long value) => ElectricResistance.FromKiloohms(value);

        /// <inheritdoc cref="ElectricResistance.FromKiloohms(UnitsNet.QuantityValue)" />
        public static ElectricResistance? Kiloohms(this long? value) => ElectricResistance.FromKiloohms(value);

        /// <inheritdoc cref="ElectricResistance.FromKiloohms(UnitsNet.QuantityValue)" />
        public static ElectricResistance Kiloohms(this double value) => ElectricResistance.FromKiloohms(value);

        /// <inheritdoc cref="ElectricResistance.FromKiloohms(UnitsNet.QuantityValue)" />
        public static ElectricResistance? Kiloohms(this double? value) => ElectricResistance.FromKiloohms(value);

        /// <inheritdoc cref="ElectricResistance.FromKiloohms(UnitsNet.QuantityValue)" />
        public static ElectricResistance Kiloohms(this float value) => ElectricResistance.FromKiloohms(value);

        /// <inheritdoc cref="ElectricResistance.FromKiloohms(UnitsNet.QuantityValue)" />
        public static ElectricResistance? Kiloohms(this float? value) => ElectricResistance.FromKiloohms(value);

        /// <inheritdoc cref="ElectricResistance.FromKiloohms(UnitsNet.QuantityValue)" />
        public static ElectricResistance Kiloohms(this decimal value) => ElectricResistance.FromKiloohms(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricResistance.FromKiloohms(UnitsNet.QuantityValue)" />
        public static ElectricResistance? Kiloohms(this decimal? value) => ElectricResistance.FromKiloohms(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Megaohm

        /// <inheritdoc cref="ElectricResistance.FromMegaohms(UnitsNet.QuantityValue)" />
        public static ElectricResistance Megaohms(this int value) => ElectricResistance.FromMegaohms(value);

        /// <inheritdoc cref="ElectricResistance.FromMegaohms(UnitsNet.QuantityValue)" />
        public static ElectricResistance? Megaohms(this int? value) => ElectricResistance.FromMegaohms(value);

        /// <inheritdoc cref="ElectricResistance.FromMegaohms(UnitsNet.QuantityValue)" />
        public static ElectricResistance Megaohms(this long value) => ElectricResistance.FromMegaohms(value);

        /// <inheritdoc cref="ElectricResistance.FromMegaohms(UnitsNet.QuantityValue)" />
        public static ElectricResistance? Megaohms(this long? value) => ElectricResistance.FromMegaohms(value);

        /// <inheritdoc cref="ElectricResistance.FromMegaohms(UnitsNet.QuantityValue)" />
        public static ElectricResistance Megaohms(this double value) => ElectricResistance.FromMegaohms(value);

        /// <inheritdoc cref="ElectricResistance.FromMegaohms(UnitsNet.QuantityValue)" />
        public static ElectricResistance? Megaohms(this double? value) => ElectricResistance.FromMegaohms(value);

        /// <inheritdoc cref="ElectricResistance.FromMegaohms(UnitsNet.QuantityValue)" />
        public static ElectricResistance Megaohms(this float value) => ElectricResistance.FromMegaohms(value);

        /// <inheritdoc cref="ElectricResistance.FromMegaohms(UnitsNet.QuantityValue)" />
        public static ElectricResistance? Megaohms(this float? value) => ElectricResistance.FromMegaohms(value);

        /// <inheritdoc cref="ElectricResistance.FromMegaohms(UnitsNet.QuantityValue)" />
        public static ElectricResistance Megaohms(this decimal value) => ElectricResistance.FromMegaohms(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricResistance.FromMegaohms(UnitsNet.QuantityValue)" />
        public static ElectricResistance? Megaohms(this decimal? value) => ElectricResistance.FromMegaohms(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Milliohm

        /// <inheritdoc cref="ElectricResistance.FromMilliohms(UnitsNet.QuantityValue)" />
        public static ElectricResistance Milliohms(this int value) => ElectricResistance.FromMilliohms(value);

        /// <inheritdoc cref="ElectricResistance.FromMilliohms(UnitsNet.QuantityValue)" />
        public static ElectricResistance? Milliohms(this int? value) => ElectricResistance.FromMilliohms(value);

        /// <inheritdoc cref="ElectricResistance.FromMilliohms(UnitsNet.QuantityValue)" />
        public static ElectricResistance Milliohms(this long value) => ElectricResistance.FromMilliohms(value);

        /// <inheritdoc cref="ElectricResistance.FromMilliohms(UnitsNet.QuantityValue)" />
        public static ElectricResistance? Milliohms(this long? value) => ElectricResistance.FromMilliohms(value);

        /// <inheritdoc cref="ElectricResistance.FromMilliohms(UnitsNet.QuantityValue)" />
        public static ElectricResistance Milliohms(this double value) => ElectricResistance.FromMilliohms(value);

        /// <inheritdoc cref="ElectricResistance.FromMilliohms(UnitsNet.QuantityValue)" />
        public static ElectricResistance? Milliohms(this double? value) => ElectricResistance.FromMilliohms(value);

        /// <inheritdoc cref="ElectricResistance.FromMilliohms(UnitsNet.QuantityValue)" />
        public static ElectricResistance Milliohms(this float value) => ElectricResistance.FromMilliohms(value);

        /// <inheritdoc cref="ElectricResistance.FromMilliohms(UnitsNet.QuantityValue)" />
        public static ElectricResistance? Milliohms(this float? value) => ElectricResistance.FromMilliohms(value);

        /// <inheritdoc cref="ElectricResistance.FromMilliohms(UnitsNet.QuantityValue)" />
        public static ElectricResistance Milliohms(this decimal value) => ElectricResistance.FromMilliohms(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricResistance.FromMilliohms(UnitsNet.QuantityValue)" />
        public static ElectricResistance? Milliohms(this decimal? value) => ElectricResistance.FromMilliohms(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Ohm

        /// <inheritdoc cref="ElectricResistance.FromOhms(UnitsNet.QuantityValue)" />
        public static ElectricResistance Ohms(this int value) => ElectricResistance.FromOhms(value);

        /// <inheritdoc cref="ElectricResistance.FromOhms(UnitsNet.QuantityValue)" />
        public static ElectricResistance? Ohms(this int? value) => ElectricResistance.FromOhms(value);

        /// <inheritdoc cref="ElectricResistance.FromOhms(UnitsNet.QuantityValue)" />
        public static ElectricResistance Ohms(this long value) => ElectricResistance.FromOhms(value);

        /// <inheritdoc cref="ElectricResistance.FromOhms(UnitsNet.QuantityValue)" />
        public static ElectricResistance? Ohms(this long? value) => ElectricResistance.FromOhms(value);

        /// <inheritdoc cref="ElectricResistance.FromOhms(UnitsNet.QuantityValue)" />
        public static ElectricResistance Ohms(this double value) => ElectricResistance.FromOhms(value);

        /// <inheritdoc cref="ElectricResistance.FromOhms(UnitsNet.QuantityValue)" />
        public static ElectricResistance? Ohms(this double? value) => ElectricResistance.FromOhms(value);

        /// <inheritdoc cref="ElectricResistance.FromOhms(UnitsNet.QuantityValue)" />
        public static ElectricResistance Ohms(this float value) => ElectricResistance.FromOhms(value);

        /// <inheritdoc cref="ElectricResistance.FromOhms(UnitsNet.QuantityValue)" />
        public static ElectricResistance? Ohms(this float? value) => ElectricResistance.FromOhms(value);

        /// <inheritdoc cref="ElectricResistance.FromOhms(UnitsNet.QuantityValue)" />
        public static ElectricResistance Ohms(this decimal value) => ElectricResistance.FromOhms(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricResistance.FromOhms(UnitsNet.QuantityValue)" />
        public static ElectricResistance? Ohms(this decimal? value) => ElectricResistance.FromOhms(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

    }
}
#endif
