﻿/*
 * Copyright (C) 2012-2014 Arctium <http://arctium.org>
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

using System;
using Framework.Configuration;
using Framework.Constants;
using System.Collections.Generic;

namespace Framework.ObjectDefines
{
    public class ChatMessageValues
    {
        // Bits
        public bool HasLanguage = false;
        public bool HasRealmId  = false;

        // Data
        public List<SmartGuid> Guids = new List<SmartGuid>(4);
        public MessageType ChatType = MessageType.ChatMessageSay;
        public byte Language        = 0;
        public int RealmId          = Convert.ToInt32(WorldConfig.RealmId);
        public string Message       = "";
        public string From          = "";

        public ChatMessageValues() { }
        public ChatMessageValues(MessageType type, string message, bool hasLanguage = false, bool hasRealmId = false, string source = "")
        {
            ChatType    = type;
            Message     = message;
            HasLanguage = hasLanguage;
            HasRealmId  = hasRealmId;
            From        = source;
        }
    }
}
