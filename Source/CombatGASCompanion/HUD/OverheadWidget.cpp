// Fill out your copyright notice in the Description page of Project Settings.


#include "OverheadWidget.h"

#include "Components/TextBlock.h"

void UOverheadWidget::SetDisplayText(FString TextToDisplay)
{
	if (DisplayText)
	{
		DisplayText->SetText(FText::FromString(TextToDisplay));
	}
}

void UOverheadWidget::ShowPlayerNetRole(APawn* InPawn)
{
	ENetRole RemoteRole = InPawn->GetLocalRole();
	FString Role;
	switch (RemoteRole)
	{
	case ROLE_Authority:
		Role = FString("Authority");
		break;
	case ROLE_AutonomousProxy:
		Role = FString("AutonomousProxy");
		break;
	case ROLE_SimulatedProxy:
		Role = FString("SimulatedProxy");
		break;
	case ROLE_None:
		Role = FString("None");
		break;
	}
	FString RemoteRoleString = FString::Printf(TEXT("LocalRole:  %s"), *Role);
	SetDisplayText(RemoteRoleString);
}

void UOverheadWidget::NativeDestruct()
{
	RemoveFromParent();
	Super::NativeDestruct();
}
