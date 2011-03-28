﻿// Copyright 2007-2010 The Apache Software Foundation.
//  
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use 
// this file except in compliance with the License. You may obtain a copy of the 
// License at 
// 
//     http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software distributed 
// under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, either express or implied. See the License for the 
// specific language governing permissions and limitations under the License.
namespace Magnum.Routing.Conditions
{
	using System.Collections.Generic;


	public class EqualRouteCondition :
		Condition,
		RouteCondition
	{
		IDictionary<string, IList<Activation>> _values;

		public EqualRouteCondition(string value)
			: this()
		{
			Add(value);
		}

		public EqualRouteCondition()
		{
			_values = new Dictionary<string, IList<Activation>>();
		}

		public void Activate(RouteContext context, string value)
		{
			IList<Activation> match;
			if (_values.TryGetValue(value, out match))
			{
				foreach (Activation activation in match)
					activation.Activate(context, value);
			}
		}

		public void Add(string value)
		{
			_values.Add(value, new List<Activation>());
		}
	}
}