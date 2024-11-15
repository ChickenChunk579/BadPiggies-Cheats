﻿using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class GetCharacterDataResult : PlayFabResultCommon
	{
		public string CharacterId;

		public Dictionary<string, UserDataRecord> Data;

		public uint DataVersion;
	}
}
