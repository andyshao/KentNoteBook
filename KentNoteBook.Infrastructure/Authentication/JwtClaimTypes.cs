﻿using System;
using System.Collections.Generic;
using System.Text;

namespace KentNoteBook.Infrastructure.Authentication
{
	public static class JwtClaimTypes
	{
		public const string Audience = "Audience";
		public const string Issuer = "Issuer";
		public const string Id = "Id";
		public const string Name = "Name";
		public const string Email = "Email";
		public const string Mobile = "Mobile";
		public const string Role = "Role";
	}
}
