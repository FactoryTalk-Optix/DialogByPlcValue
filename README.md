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

## Disclaimer

Rockwell Automation maintains these repositories as a convenience to you and other users. Although Rockwell Automation reserves the right at any time and for any reason to refuse access to edit or remove content from this Repository, you acknowledge and agree to accept sole responsibility and liability for any Repository content posted, transmitted, downloaded, or used by you. Rockwell Automation has no obligation to monitor or update Repository content

The examples provided are to be used as a reference for building your own application and should not be used in production as-is. It is recommended to adapt the example for the purpose, observing the highest safety standards.
