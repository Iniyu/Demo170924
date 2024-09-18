const webRessourcesMessagesPath = "demo_/resx/messages";

async function onClickCountContacts(formContext: Xrm.FormContext) {
    let ticks: number = getTicks();
    spinner(true);

    var countedContactsString: string = await countContacts(formContext);
    var dialogText = setDialogText(countedContactsString);

    var endTicks: any;
    while (endTicks == null || endTicks == undefined || endTicks - ticks <= 2000) {
        endTicks = getTicks();
    }
    spinner(false);
    openAlertDialog(dialogText);

}

async function countContacts(formContext: Xrm.FormContext) {
    let count: number;
    let countString: string;
    let contactsOnAccount: any = await fetchContacts(formContext);
    if (contactsOnAccount != null || contactsOnAccount != undefined) {
        count = contactsOnAccount.length;
        countString = count.toString();
    } else {
        countString = "keine";
    }
    return countString;
}

async function fetchContacts(formContext: Xrm.FormContext) {
    const accountID: string = formContext.data.entity.getId();
    let query: string = `?$filter=_parentcustomerid_value eq ${accountID}`;
    let contacts: Xrm.RetrieveMultipleResult = await Xrm.WebApi.retrieveMultipleRecords("contact", query);
    let response: any;
    if (contacts != null) {
        response = contacts.entities;
    } else {
        response = null;
    }
    return response;
}

function openAlertDialog(dialogMessage: string) {
    const buttonTextKey: string = "alert_dialog_confirm";
    const buttonText: string = Xrm.Utility.getResourceString(webRessourcesMessagesPath, buttonTextKey);
    let alertStrings: Xrm.Navigation.AlertStrings = { confirmButtonLabel: buttonText, text: dialogMessage };
    let alertOptions: Xrm.Navigation.DialogSizeOptions = { height: 120, width: 260 };
    Xrm.Navigation.openAlertDialog(alertStrings, alertOptions).then(
        function (success) {
            console.log("Alert dialog closed");
        },
        function (error) {
            console.log(error.message);
        }
    );
}

function spinner(show: boolean) {
    const dialogKey: string = "spinner_countContact";
    const dialogText: string = Xrm.Utility.getResourceString(webRessourcesMessagesPath, dialogKey);
    if (show) {
        Xrm.Utility.showProgressIndicator(dialogText);
    } else {
        setTimeout(x => { Xrm.Utility.closeProgressIndicator() }, 2000);
        console.log("Spinner closed");
    }
}

function getTicks() {
    var getDate: any = new Date();
    var ticks: number = getDate.getTime();
    return ticks;
}

function setDialogText(countedContactsString: string) {

    let dialogKey: string;
    let dialogText: string;

    if (countedContactsString == "1") {
        dialogKey = "count_contacts_one";
    } else {
        dialogKey = "count_contacts";
    }

    dialogText = Xrm.Utility.getResourceString(webRessourcesMessagesPath, dialogKey);
    dialogText = dialogText.replace("x", countedContactsString);
    return dialogText;
}