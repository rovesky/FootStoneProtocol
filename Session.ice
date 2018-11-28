﻿
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
    
    //
    // The session object. This is used to create per-session objects on
    // behalf of the client.
    //
    interface Session
    {
        //
        // Create a new per-session hello object. The created object will
        // be automatically destroyed when the session is destroyed.
        //
        Player* createPlayer();

        idempotent string getName();

        //
        // Destroy the session explicitly.
        //
        void destroy();
    }

    interface SessionFactory
    {
       //
        // Create a session with the given name. Note that the name is
        // only used for diagnostic purposes. It is not used as unique
        // session id.
        //
        Session* create(string name);

        void shutdown();
    }
	}

}