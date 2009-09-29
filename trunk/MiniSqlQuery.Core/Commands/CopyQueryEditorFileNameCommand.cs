﻿using System;
using System.Windows.Forms;

namespace MiniSqlQuery.Core.Commands
{
	public class CopyQueryEditorFileNameCommand
		: CommandBase
	{
		public CopyQueryEditorFileNameCommand()
			: base("Copy Filename")
		{
		}

		public override void Execute()
		{
			IEditor editor = HostWindow.Instance.ActiveMdiChild as IEditor;
			if (editor != null && editor.FileName != null)
			{
				Clipboard.SetText(editor.FileName);
			}
		}
	}
}