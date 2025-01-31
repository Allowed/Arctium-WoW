﻿/*
 * Copyright (C) 2012-2014 Arctium Emulation <http://arctium.org>
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

using Framework.Attributes;

namespace Framework.Database.Character.Entities
{
    public class CharacterTemplateAction
    {
        [Field(PrimaryKey = true)]
        public int ClassId { get; set; }
        public int Action  { get; set; }
        public byte Slot   { get; set; }

        public virtual CharacterTemplateClass CharacterTemplateClass { get; set; }
    }
}
