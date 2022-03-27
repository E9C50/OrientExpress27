// Copyright Epic Games, Inc. All Rights Reserved.

#include "OrientExpress27GameMode.h"
#include "OrientExpress27Character.h"
#include "UObject/ConstructorHelpers.h"

AOrientExpress27GameMode::AOrientExpress27GameMode()
{
	// set default pawn class to our Blueprinted character
	static ConstructorHelpers::FClassFinder<APawn> PlayerPawnBPClass(TEXT("/Game/Blueprints/ThirdPersonCharacter"));
	if (PlayerPawnBPClass.Class != NULL)
	{
		DefaultPawnClass = PlayerPawnBPClass.Class;
	}
}
