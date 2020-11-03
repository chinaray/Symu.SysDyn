﻿#region Licence

// Description: SymuSysDyn - SymuSysDyn
// Website: https://symu.org
// Copyright: (c) 2020 laurent Morisseau
// License : the program is distributed under the terms of the GNU General Public License

#endregion

#region using directives

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Symu.SysDyn.Parser;

#endregion

namespace Symu.SysDyn.Models
{
    /// <summary>
    ///     Define a XMile model with the list of all its variables, modules and groups
    /// </summary>
    public class Model
    {
        /// <summary>
        /// Name is mandatory for the subModels
        /// </summary>
        /// <param name="name"></param>
        public Model(string name)
        {
            Name = name != null ? StringUtils.CleanName(name) : string.Empty;
        }
        /// <summary>
        /// The name of the model
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// List of all the variables of the model
        /// </summary>
        public VariableCollection Variables { get; private set; } = new VariableCollection();
        /// <summary>
        /// List of all the groups of the model
        /// </summary>
        public GroupCollection Groups { get; private set; } = new GroupCollection();

        public void Initialize()
        {
            Variables.Initialize();
        }

        /// <summary>
        ///     Get the VariableCollection of a group
        /// </summary>
        /// <param name="groupName"></param>
        /// <returns></returns>
        public VariableCollection GetGroupVariables(string groupName)
        {
            return GetGroupVariables(Groups.Get(groupName));
        }

        /// <summary>
        ///     Get the list of variables of a group
        /// </summary>
        /// <param name="group"></param>
        /// <returns></returns>
        public VariableCollection GetGroupVariables(Group group)
        {
            if (group == null)
            {
                throw new ArgumentNullException(nameof(group));
            }
            var variables = new VariableCollection();
            foreach (var entity in group.Entities)
            {
                variables.Add(Variables.Get(entity));
            }

            return variables;
        }

        public void Clear()
        {
            Variables.Clear();
            Groups.Clear();
        }

        public Model Clone()
        {
            var clone = new Model(Name)
            {
                Groups = Groups,
                Variables = Variables.Clone()
            };

            return clone;
        }
    }
}