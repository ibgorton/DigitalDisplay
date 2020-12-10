﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkeuomorphCommon
{
    public static class RectangleMap
    {

    }
    public static class SixteenMap
    {
        private static readonly Dictionary<char, BitArray> SixteenBits = new()
        {
            { ' ', new BitArray(values: new int[] { 0 }) { Length = 16 } },
            { '!', new BitArray(values: new int[] { 12 }) { Length = 16 } },
            { '"', new BitArray(values: new int[] { 516 }) { Length = 16 } },
            { '(', new BitArray(values: new int[] { 5120 }) { Length = 16 } },
            { ')', new BitArray(values: new int[] { 16640 }) { Length = 16 } },
            { '*', new BitArray(values: new int[] { 65280 }) { Length = 16 } },
            { '+', new BitArray(values: new int[] { 43520 }) { Length = 16 } },
            { ',', new BitArray(values: new int[] { 16384 }) { Length = 16 } },
            { '-', new BitArray(values: new int[] { 34816 }) { Length = 16 } },
            { '/', new BitArray(values: new int[] { 17408 }) { Length = 16 } },
            { '0', new BitArray(values: new int[] { 17663 }) { Length = 16 } },
            { '1', new BitArray(values: new int[] { 1036 }) { Length = 16 } },
            { '2', new BitArray(values: new int[] { 34935 }) { Length = 16 } },
            { '3', new BitArray(values: new int[] { 2111 }) { Length = 16 } },
            { '4', new BitArray(values: new int[] { 34956 }) { Length = 16 } },
            { '5', new BitArray(values: new int[] { 37043 }) { Length = 16 } },
            { '6', new BitArray(values: new int[] { 35067 }) { Length = 16 } },
            { '7', new BitArray(values: new int[] { 15 }) { Length = 16 } },
            { '8', new BitArray(values: new int[] { 35071 }) { Length = 16 } },
            { '9', new BitArray(values: new int[] { 35007 }) { Length = 16 } },
            { ':', new BitArray(values: new int[] { 8704 }) { Length = 16 } },
            { ';', new BitArray(values: new int[] { 16896 }) { Length = 16 } },
            { '<', new BitArray(values: new int[] { 37888 }) { Length = 16 } },
            { '=', new BitArray(values: new int[] { 34864 }) { Length = 16 } },
            { '>', new BitArray(values: new int[] { 18688 }) { Length = 16 } },
            { '?', new BitArray(values: new int[] { 10247 }) { Length = 16 } },
            { '@', new BitArray(values: new int[] { 2807 }) { Length = 16 } },
            { 'A', new BitArray(values: new int[] { 35023 }) { Length = 16 } },
            { 'B', new BitArray(values: new int[] { 10815 }) { Length = 16 } },
            { 'C', new BitArray(values: new int[] { 243 }) { Length = 16 } },
            { 'D', new BitArray(values: new int[] { 8767 }) { Length = 16 } },
            { 'E', new BitArray(values: new int[] { 33011 }) { Length = 16 } },
            { 'F', new BitArray(values: new int[] { 32963 }) { Length = 16 } },
            { 'G', new BitArray(values: new int[] { 2299 }) { Length = 16 } },
            { 'H', new BitArray(values: new int[] { 35020 }) { Length = 16 } },
            { 'I', new BitArray(values: new int[] { 8755 }) { Length = 16 } },
            { 'J', new BitArray(values: new int[] { 124 }) { Length = 16 } },
            { 'K', new BitArray(values: new int[] { 38080 }) { Length = 16 } },
            { 'L', new BitArray(values: new int[] { 240 }) { Length = 16 } },
            { 'M', new BitArray(values: new int[] { 1484 }) { Length = 16 } },
            { 'N', new BitArray(values: new int[] { 4556 }) { Length = 16 } },
            { 'O', new BitArray(values: new int[] { 255 }) { Length = 16 } },
            { 'P', new BitArray(values: new int[] { 35015 }) { Length = 16 } },
            { 'Q', new BitArray(values: new int[] { 4351 }) { Length = 16 } },
            { 'R', new BitArray(values: new int[] { 39111 }) { Length = 16 } },
            { 'S', new BitArray(values: new int[] { 35003 }) { Length = 16 } },
            { 'T', new BitArray(values: new int[] { 8707 }) { Length = 16 } },
            { 'U', new BitArray(values: new int[] { 252 }) { Length = 16 } },
            { 'V', new BitArray(values: new int[] { 17600 }) { Length = 16 } },
            { 'W', new BitArray(values: new int[] { 20684 }) { Length = 16 } },
            { 'X', new BitArray(values: new int[] { 21760 }) { Length = 16 } },
            { 'Y', new BitArray(values: new int[] { 35004 }) { Length = 16 } },
            { 'Z', new BitArray(values: new int[] { 17459 }) { Length = 16 } },
            { '[', new BitArray(values: new int[] { 8722 }) { Length = 16 } },
            { '\\', new BitArray(values: new int[] { 4352 }) { Length = 16 } },
            { ']', new BitArray(values: new int[] { 8737 }) { Length = 16 } },
            { '^', new BitArray(values: new int[] { 20480 }) { Length = 16 } },
            { '_', new BitArray(values: new int[] { 48 }) { Length = 16 } },
            { '`', new BitArray(values: new int[] { 256 }) { Length = 16 } },
            { 'a', new BitArray(values: new int[] { 41072 }) { Length = 16 } },
            { 'b', new BitArray(values: new int[] { 41184 }) { Length = 16 } },
            { 'c', new BitArray(values: new int[] { 32864 }) { Length = 16 } },
            { 'd', new BitArray(values: new int[] { 10268 }) { Length = 16 } },
            { 'e', new BitArray(values: new int[] { 49248 }) { Length = 16 } },
            { 'f', new BitArray(values: new int[] { 43522 }) { Length = 16 } },
            { 'g', new BitArray(values: new int[] { 41633 }) { Length = 16 } },
            { 'h', new BitArray(values: new int[] { 41152 }) { Length = 16 } },
            { 'i', new BitArray(values: new int[] { 8192 }) { Length = 16 } },
            { 'j', new BitArray(values: new int[] { 8800 }) { Length = 16 } },
            { 'k', new BitArray(values: new int[] { 13824 }) { Length = 16 } },
            { 'l', new BitArray(values: new int[] { 192 }) { Length = 16 } },
            { 'm', new BitArray(values: new int[] { 43080 }) { Length = 16 } },
            { 'n', new BitArray(values: new int[] { 41024 }) { Length = 16 } },
            { 'o', new BitArray(values: new int[] { 41056 }) { Length = 16 } },
            { 'p', new BitArray(values: new int[] { 33473 }) { Length = 16 } },
            { 'q', new BitArray(values: new int[] { 41601 }) { Length = 16 } },
            { 'r', new BitArray(values: new int[] { 32832 }) { Length = 16 } },
            { 's', new BitArray(values: new int[] { 41121 }) { Length = 16 } },
            { 't', new BitArray(values: new int[] { 32992 }) { Length = 16 } },
            { 'u', new BitArray(values: new int[] { 8288 }) { Length = 16 } },
            { 'v', new BitArray(values: new int[] { 16448 }) { Length = 16 } },
            { 'w', new BitArray(values: new int[] { 20552 }) { Length = 16 } },
            { 'x', new BitArray(values: new int[] { 21760 }) { Length = 16 } },
            { 'y', new BitArray(values: new int[] { 2588 }) { Length = 16 } },
            { 'z', new BitArray(values: new int[] { 49184 }) { Length = 16 } },
            { '{', new BitArray(values: new int[] { 41490 }) { Length = 16 } },
            { '|', new BitArray(values: new int[] { 8704 }) { Length = 16 } },
            { '}', new BitArray(values: new int[] { 10785 }) { Length = 16 } }
        };

        public static BitArray GetBitsSixteen(this char c) => SixteenBits.ContainsKey(key: c) ? SixteenBits[key: c] : new BitArray(length: 16);
    }
    public static class SevenMap
    {
        private static readonly Dictionary<char, bool[]> SevenBits = new()
        {
            { '-', new bool[7] { true, false, false, false, false, false, false } },
            { '0', new bool[7] { false, true, true, true, true, true, true, } },
            { '1', new bool[7] { false, false, false, false, true, true, false } },
            { '2', new bool[7] { true, false, true, true, false, true, true } },
            { '3', new bool[7] { true, false, false, true, true, true, true } },
            { '4', new bool[7] { true, true, false, false, true, true, false} },
            { '5', new bool[7] { true, true, false, true, true, false, true } },
            { '6', new bool[7] { true, true, true, true, true, false, true } },
            { '7', new bool[7] { false, false, false, false, true, true, true} },
            { '8', new bool[7] { true, true, true, true, true, true, true} },
            { '9', new bool[7] { true, true, false, true, true, true, true } },
            { '=', new bool[7] { true, false, false, true, false, false, false } },
            { 'A', new bool[7] { true, true, true, false, true, true, true } },
            { 'B', new bool[7] { true, true, true, true, true, false, false } },
            { 'C', new bool[7] { false, true, true, true, false, false, true } },
            { 'D', new bool[7] { true, false, true, true, true, true, false } },
            { 'E', new bool[7] { true, true, true, true, false, false, true } },
            { 'F', new bool[7] { true, true, true, false, false, false, true } },
            { 'G', new bool[7] { false, true, true, true, true, false, true } },
            { 'H', new bool[7] { true, true, true, false, true, true, false } },
            { '_', new bool[7] { false, false, false, true, false, false, false } },
            { 'r', new bool[7] { true, false, true, false, false, false, false } },
            { 'o', new bool[7] { true, false, true, true, true, false, false} }
        };

        public static void GetBitSeven(this bool[] t, char c)
        {
            if (SevenBits.ContainsKey(key: c))
            {
                SevenBits[key: c].Reverse().ToArray().CopyTo(array: t, index: 0);
                //SevenBits[key: c].CopyTo(array: t, index: 0);
            }
        }

    }
}