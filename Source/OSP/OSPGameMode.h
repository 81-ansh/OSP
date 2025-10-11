// Copyright Epic Games, Inc. All Rights Reserved.

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/GameModeBase.h"
#include "OSPGameMode.generated.h"

/**
 *  Simple GameMode for a third person game
 */
UCLASS(abstract)
class AOSPGameMode : public AGameModeBase
{
	GENERATED_BODY()

public:
	
	/** Constructor */
	AOSPGameMode();
};



