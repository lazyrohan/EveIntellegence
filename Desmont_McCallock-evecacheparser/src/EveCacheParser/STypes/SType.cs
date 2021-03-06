﻿# region License
/* EVECacheParser - .NET 4/C# EVE Cache File Parser Library
 * Copyright © 2012 Jimi 'Desmont McCallock' C <jimikar@gmail.com>
 *
 * Based on:
 * - reverence - Python library for processing EVE Online cache and bulkdata
 *    Copyright © 2003-2011 Jamie 'Entity' van den Berge <jamie@hlekkir.com>
 *    https://github.com/ntt/reverence
 *
 * - libevecache - C++ EVE online reverse engineered cache reading library
 *    Copyright © 2009-2010  StackFoundry LLC and Yann 'Kaladr' Ramin <yann@stackfoundry.com>
 *    http://dev.eve-central.com/libevecache/
 *    http://gitorious.org/libevecache
 *    https://github.com/theatrus/libevecache
 *
 * - EveCache.Net - A port of libevecache to C#
 *    Copyright © 2011 Jason 'Jay Wareth' Watkins <jason@blacksunsystems.net>
 *    https://github.com/jwatkins42/EveCache.Net
 * 
 * This library is free software; you can redistribute it and/or
 * modify it under the terms of the GNU General Public
 * License as published by the Free Software Foundation; either
 * version 2 of the License, or (at your option) any later version.
 *
 * This library is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
 * General Public License for more details.
 *
 * You should have received a copy of the GNU General Public
 * License along with this library; if not, write to the Free Software
 * Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301  USA
 */
# endregion

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using EveCacheParser.Enumerations;

namespace EveCacheParser.STypes
{
    abstract class SType
    {
        #region Fields

        protected readonly int DebugID;

        readonly StreamType m_streamType;

        static readonly Dictionary<int, bool> s_typeConsumed = new Dictionary<int, bool>();
        static readonly List<SType> s_type = new List<SType>();
        static int s_count;

        #endregion


        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SType"/> class.
        /// </summary>
        /// <param name="streamType">Type of the stream.</param>
        protected SType(StreamType streamType)
        {
            DebugID = s_count++;
            s_type.Add(this);

            m_streamType = streamType;
            Members = new List<SType>();
        }

        #endregion


        #region Properties

        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        /// <value>The text.</value>
        internal string Text { get; set; }

        /// <summary>
        /// Gets or sets the integral value.
        /// </summary>
        /// <value>The integral value.</value>
        internal long Value { get; set; }

        /// <summary>
        /// Gets or sets the double value.
        /// </summary>
        /// <value>The double value.</value>
        internal double DoubleValue { get; set; }

        /// <summary>
        /// Gets or sets a boolean.
        /// </summary>
        /// <value>The boolean value.</value>
        internal bool Boolean { get; set; }

        /// <summary>
        /// Gets or sets the members.
        /// </summary>
        /// <value>The members.</value>
        internal List<SType> Members { get; private set; }

        #endregion


        #region Static Methods

        /// <summary>
        /// Resets this instance.
        /// </summary>
        internal static void Reset()
        {
            s_type.Clear();
            s_typeConsumed.Clear();
            s_count = 0;
        }

        /// <summary>
        /// Dumps the structure of the stream types.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        internal static void DumpTypes(string fileName)
        {
            s_type.ForEach(type => s_typeConsumed[type.DebugID] = false);
            
            var fileContents = new StringBuilder();
            foreach (var type in s_type.Where(type => !s_typeConsumed[type.DebugID]))
            {
                if (type.m_streamType == StreamType.StreamStart)
                {
                    s_typeConsumed[type.DebugID] = true;
                    continue;
                }

                fileContents.Append(type.ToString());
                fileContents.AppendFormat("[{0:00}]\n", type.DebugID);
                fileContents.Append(DumpType(type, 1));

                s_typeConsumed[type.DebugID] = true;
            }
            File.WriteAllText(Path.ChangeExtension(fileName, ".structure"), fileContents.ToString());
        }

        /// <summary>
        /// Dumps the structure of the stream types.
        /// </summary>
        /// <param name="sType">The stream type.</param>
        /// <param name="offset">The offset.</param>
        /// <returns></returns>
        static string DumpType(SType sType, int offset)
        {
            if (!sType.Members.Any())
                return String.Empty;

            var sb = new StringBuilder();
            foreach (var type in sType.Members)
            {
                sb.Append(type.ToString().PadLeft((2 * offset) + type.ToString().Length)); //Algin with space
                sb.AppendFormat("[{0:00}]\n", type.DebugID);//Output debug ID
                if (type.Members.Any())
                    sb.Append(DumpType(type, offset + 1)); //More space?
                s_typeConsumed[type.DebugID] = true;
            }

            return sb.ToString();
        }

        internal static Dictionary<object, object> ToDictionary(IList<SType> members, int sortCriteria = 0)
        {
            var dictionary = new Dictionary<object, object>();
            object key = null;
            object value = null;
            foreach (var member in members)
            {
                // 'sortCriteria' determines which members are keys
                if (members.IndexOf(member) % 2 == sortCriteria)
                    key = member.ToObject();
                else
                    // 'sortCriteria' determines which members are values
                    value = member.ToObject();

                // Keep iterating till we have a pair
                if (key == null || value == null)
                    continue;

                // Add to dictionary
                dictionary.Add(key, value);

                // Reset
                key = null;
                value = null;
            }

            return dictionary;

        }

        #endregion


        #region Methods

        /// <summary>
        /// Adds the member.
        /// </summary>
        /// <param name="type">The type.</param>
        internal virtual void AddMember(SType type)
        {
            if (type != null)
                Members.Add(type);
        }

        /// <summary>
        /// Returns a <see cref="System.Object"/> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.Object"/> that represents this instance.
        /// </returns>
        internal abstract object ToObject();

        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns>A memberwise clone of this instance.</returns>
        internal abstract SType Clone();

        #endregion
    }
}
