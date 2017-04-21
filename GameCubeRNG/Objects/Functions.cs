/*
 * This file is part of RNG Reporter
 * Copyright (C) 2012 by Bill Young, Mike Suleski, and Andrew Ringer
 *
 * This program is free software; you can redistribute it and/or
 * modify it under the terms of the GNU General Public License
 * as published by the Free Software Foundation; either version 2
 * of the License, or (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
 */

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace GameCubeRNG.Objects
{
    internal static class Functions
    {
        public static bool Shiny(uint PID, ushort TID, ushort SID)
        {
            return ((((PID & 0xFFFF) ^ (PID >> 16) ^ TID ^ SID) & 0xFFF8) == 0);
        }

        public static string NatureStrings(int nature)
        {
            if (nature == -2)
            {
                return "Any";
            }

            if (nature == -1)
            {
                return "None";
            }

            String[] natures = new String[] { "Hardy", "Lonely", "Brave", "Adamant", "Naughty", "Bold", "Docile", "Relaxed", "Impish", "Lax", "Timid", "Hasty", "Serious", "Jolly", "Naive", "Modest", "Mild", "Quiet", "Bashful", "Rash", "Calm", "Gentle", "Sassy", "Careful", "Quirky" };
            return natures[nature];
        }

        public static int NatureNumber(String nature)
        {
            switch (nature)
            {
                case "Hardy":
                    return 0;
                case "Lonely":
                    return 1;
                case "Brave":
                    return 2;
                case "Adamant":
                    return 3;
                case "Naughty":
                    return 4;
                case "Bold":
                    return 5;
                case "Docile":
                    return 6;
                case "Relaxed":
                    return 7;
                case "Impish":
                    return 8;
                case "Lax":
                    return 9;
                case "Timid":
                    return 10;
                case "Hasty":
                    return 11;
                case "Serious":
                    return 12;
                case "Jolly":
                    return 13;
                case "Naive":
                    return 14;
                case "Modest":
                    return 15;
                case "Mild":
                    return 16;
                case "Quiet":
                    return 17;
                case "Bashful":
                    return 18;
                case "Rash":
                    return 19;
                case "Calm":
                    return 20;
                case "Gentle":
                    return 21;
                case "Sassy":
                    return 22;
                case "Careful":
                    return 23;
                default:
                    return 24;
            }
        }
    }
}