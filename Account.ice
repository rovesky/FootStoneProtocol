
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
		exception AccountException
		{
			string message;
		}

		struct RegisterInfo
		{
			string account;
			string password;
		}

		struct LoginInfo
		{
			string account;
			string password;
		}
		
		interface Account
		{
      
		  ["amd"] void LoginRequest(LoginInfo info) throws AccountException;

		  ["amd"] void RegisterRequest(RegisterInfo info) throws AccountException;
      
	      ["amd"] string CreatePlayer(string name,int serverId) throws AccountException;

		}
    
	}

}