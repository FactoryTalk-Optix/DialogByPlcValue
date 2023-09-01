#region Using directives
using System;
using UAManagedCore;
using OpcUa = UAManagedCore.OpcUa;
using FTOptix.HMIProject;
using FTOptix.UI;
using FTOptix.Retentivity;
using FTOptix.NativeUI;
using FTOptix.Core;
using FTOptix.CoreBase;
using FTOptix.NetLogic;
#endregion

public class DialogTrigger : BaseNetLogic
{
    public override void Start()
    {
        // Insert code to be executed when the user-defined logic is started
        IUAVariable myVar = InformationModel.GetVariable(LogicObject.GetVariable("InputVariable").Value);
        if (myVar.GetType().FullName.Contains("Tag")) {
            variableSynchronizer = new RemoteVariableSynchronizer();
            variableSynchronizer.Add(myVar);
        }
        myVar.VariableChange += MyVar_VariableChange;
    }

    private void MyVar_VariableChange(object sender, VariableChangeEventArgs e) {
        try {
            var myDialog = InformationModel.Get<DialogType>(LogicObject.GetVariable("DialogValue" + e.NewValue.Value.ToString()).Value);
            UICommands.OpenDialog((Window)Owner, myDialog);
        } catch {
            Log.Warning("No corresponding DialogBox for value: " + e.NewValue.ToString());
        }
    }

    public override void Stop()
    {
        // Insert code to be executed when the user-defined logic is stopped
    }
    private RemoteVariableSynchronizer variableSynchronizer;
}
