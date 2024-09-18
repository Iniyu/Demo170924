"use strict";
var Demo;
(function (Demo) {
    class Account {
        constructor(executionContext) {
            this.webRessourcesPath = "demo_/resx/messages";
            this.executionContext = executionContext;
            this.formContext = executionContext.getFormContext();
            this.onLoad();
        }
        onLoad() {
        }
    }
    Demo.Account = Account;
})(Demo || (Demo = {}));
