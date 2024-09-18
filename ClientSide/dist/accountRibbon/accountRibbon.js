"use strict";
const webRessourcesMessagesPath = "demo_/resx/messages";
async function onClickCountContacts(formContext) {
    let ticks = getTicks();
    spinner(true);
    var countedContactsString = await countContacts(formContext);
    var dialogText = setDialogText(countedContactsString);
    var endTicks;
    while (endTicks == null || endTicks == undefined || endTicks - ticks <= 2000) {
        endTicks = getTicks();
    }
    spinner(false);
    openAlertDialog(dialogText);
}
async function countContacts(formContext) {
    let count;
    let countString;
    let contactsOnAccount = await fetchContacts(formContext);
    if (contactsOnAccount != null || contactsOnAccount != undefined) {
        count = contactsOnAccount.length;
        countString = count.toString();
    }
    else {
        countString = "keine";
    }
    return countString;
}
async function fetchContacts(formContext) {
    const accountID = formContext.data.entity.getId();
    let query = `?$filter=_parentcustomerid_value eq ${accountID}`;
    let contacts = await Xrm.WebApi.retrieveMultipleRecords("contact", query);
    let response;
    if (contacts != null) {
        response = contacts.entities;
    }
    else {
        response = null;
    }
    return response;
}
function openAlertDialog(dialogMessage) {
    const buttonTextKey = "alert_dialog_confirm";
    const buttonText = Xrm.Utility.getResourceString(webRessourcesMessagesPath, buttonTextKey);
    let alertStrings = { confirmButtonLabel: buttonText, text: dialogMessage };
    let alertOptions = { height: 120, width: 260 };
    Xrm.Navigation.openAlertDialog(alertStrings, alertOptions).then(function (success) {
        console.log("Alert dialog closed");
    }, function (error) {
        console.log(error.message);
    });
}
function spinner(show) {
    const dialogKey = "spinner_countContact";
    const dialogText = Xrm.Utility.getResourceString(webRessourcesMessagesPath, dialogKey);
    if (show) {
        Xrm.Utility.showProgressIndicator(dialogText);
    }
    else {
        setTimeout(x => { Xrm.Utility.closeProgressIndicator(); }, 2000);
        console.log("Spinner closed");
    }
}
function getTicks() {
    var getDate = new Date();
    var ticks = getDate.getTime();
    return ticks;
}
function setDialogText(countedContactsString) {
    let dialogKey;
    let dialogText;
    if (countedContactsString == "1") {
        dialogKey = "count_contacts_one";
    }
    else {
        dialogKey = "count_contacts";
    }
    dialogText = Xrm.Utility.getResourceString(webRessourcesMessagesPath, dialogKey);
    dialogText = dialogText.replace("x", countedContactsString);
    return dialogText;
}
