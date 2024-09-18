export interface ExecutionContext extends Xrm.Events.EventContext {

}
declare global {
    interface ExecutionContext extends Xrm.Events.EventContext {}
}