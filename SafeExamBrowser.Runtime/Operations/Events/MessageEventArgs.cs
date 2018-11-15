﻿/*
 * Copyright (c) 2018 ETH Zürich, Educational Development and Technology (LET)
 * 
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/.
 */

using System.Collections.Generic;
using SafeExamBrowser.Contracts.Core.OperationModel.Events;
using SafeExamBrowser.Contracts.I18n;
using SafeExamBrowser.Contracts.UserInterface.MessageBox;

namespace SafeExamBrowser.Runtime.Operations.Events
{
	internal class MessageEventArgs : ActionRequiredEventArgs
	{
		internal MessageBoxIcon Icon { get; set; }
		internal TextKey Message { get; set; }
		internal TextKey Title { get; set; }
		internal Dictionary<string, string> MessagePlaceholders { get; private set; }
		internal Dictionary<string, string> TitlePlaceholders { get; private set; }

		public MessageEventArgs()
		{
			MessagePlaceholders = new Dictionary<string, string>();
			TitlePlaceholders = new Dictionary<string, string>();
		}
	}
}