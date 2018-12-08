
// **********************************************************************
//
// Copyright (c) 2003-2018 ZeroC, Inc. All rights reserved.
//
// **********************************************************************
#pragma once

#include "Player.ice"


module FootStone
{
	module GrainInterfaces
	{   
		sequence<byte> Bytes;

		interface IZonePush
		{
			void ZoneSync(Bytes data);
		}
   
		interface IZone
		{ 
		    void PlayerEnter(string zoneId);

		    void Move(Bytes data);
		
		}  		
	}
}