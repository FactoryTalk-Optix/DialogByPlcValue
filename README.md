# Open DialogBox by Value from PLC
This example shows how to open a specific DialogBox from a Tag (Model or PLC)

## Instructions
- Browse to `UI/MainWindow/DialogTrigger` and set the input variable that receives the trigger
	- This variable can be both a Model variable or a PLC tag, in the case of a PLC tag the VariableSynchronizer is automatically executed
- Copy/Paste the `DialogValueX` NodePointer, each variable corresponds to a value from the PLC	
	- Tag Value: 1 -> DialogValue1
	- Tag Value: 2 -> DialogValue2
	- etc...
	- Hint: leave the value 0 without any NodePointer, otherwise a dialog will be triggered every time the value resets or the PLC starts
- Link each `DialogValueX` NodePointer to a DialogBox that has to be triggered

## Additional notes
- Opening a new Dialog will not close the previous one
