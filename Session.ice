
// **********************************************************************
//
// Copyright (c) 2003-2018 ZeroC, Inc. All rights reserved.
//
// **********************************************************************
#pragma once
#include "Player.ice"

//using FootStone.GrainInterfaces;

module FootStone
{
	module GrainInterfaces
	{   
	
	
		interface SessionPush
		{
			
		}
   
		interface Session
		{      

			["amd"] void Ping();

			["amd"] void AddPush(SessionPush* playerPush);

		}  
	}
}