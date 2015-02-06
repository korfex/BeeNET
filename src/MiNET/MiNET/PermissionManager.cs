﻿using System.Collections.Generic;

namespace MiNET
{
	public class PermissionManager
	{
		private UserGroup Group { get; set; }
		private List<string> Permissions { get; set; }

		public PermissionManager(UserGroup group)
		{
			Permissions = new List<string>();
			Group = group;
			//Permissions.Add("*");
		}

		public void AddPermission(string permission)
		{
			Permissions.Add(permission);
		}

		public bool HasPermission(string permission)
		{
			return Permissions.Contains(permission);
		}

		public void RemovePermission(string permission)
		{
			if (Permissions.Contains(permission))
			{
				Permissions.Remove(permission);
			}
		}

		public bool IsInGroup(UserGroup group)
		{
			return Group == @group;
		}

		public void SetGroup(UserGroup group)
		{
			Group = group;
		}
	}

	public enum UserGroup
	{
		Operator = 1,
		User = 0
	}
}