namespace Demo{
    export class Account {
        private readonly webRessourcesPath = "demo_/resx/messages";
        private executionContext: Xrm.Events.EventContext;
        private formContext: Xrm.FormContext;
    
        constructor(executionContext: Xrm.Events.EventContext) {
            this.executionContext = executionContext;
            this.formContext = executionContext.getFormContext();
            this.onLoad();
        }
    
        private onLoad() {
            
        }    
    }
}

