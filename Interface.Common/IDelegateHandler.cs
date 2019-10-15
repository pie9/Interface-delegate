namespace Interface.Common
{
    public delegate double ResultHandler();
    public delegate void OutboundResultHandler(string type, double result);

    public interface IDelegateHandler
    {
        ResultHandler ResultHandlerdelegate { get; set; }
        OutboundResultHandler OutboundResult { get; set; }
    }
}
