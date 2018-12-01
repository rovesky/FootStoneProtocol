
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
			void SessionDestroyed();
		}
   
		interface Session
		{      
		
		   ["amd"] void AddPush(SessionPush* playerPush);
		
			void Destroy();
		}  

		interface SessionFactory
		{
		   
			Session* CreateSession(string name,string password);

			void Shutdown();
		}
	}
}