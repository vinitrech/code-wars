namespace katas.ASimplisticTCPFiniteStateMachine;

public class ASimplisticTCPFiniteStateMachineKata
{
    private const string ClosedState = "CLOSED";
    private const string ClosedWaitState = "CLOSE_WAIT";
    private const string ClosingState = "CLOSING";
    private const string ListenState = "LISTEN";
    private const string SynSentState = "SYN_SENT";
    private const string SynReceivedState = "SYN_RCVD";
    private const string FinWaitOneState = "FIN_WAIT_1";
    private const string FinWaitTwoState = "FIN_WAIT_2";
    private const string EstablishedState = "ESTABLISHED";
    private const string TimeWaitState = "TIME_WAIT";
    private const string LastAckState = "LAST_ACK";

    public static string TraverseStates(string[] events)
    {
        var state = ClosedState;

        foreach (var eventItem in events)
        {
            var newState = TryGetNewState(state, eventItem);

            if (string.IsNullOrWhiteSpace(newState))
                return "ERROR";

            state = newState;
        }

        return state;
    }

    private static string TryGetNewState(string state, string eventItem) =>
        state switch
        {
            ClosedState when eventItem is "APP_PASSIVE_OPEN" => ListenState,
            ClosedState when eventItem is "APP_ACTIVE_OPEN" => SynSentState,
            ListenState when eventItem is "APP_SEND" => SynSentState,
            ListenState or SynSentState when eventItem is "RCV_SYN" => SynReceivedState,
            ListenState or SynSentState when eventItem is "APP_CLOSE" => ClosedState,
            TimeWaitState when eventItem is "APP_TIMEOUT" => ClosedState,
            LastAckState when eventItem is "RCV_ACK" => ClosedState,
            SynReceivedState or EstablishedState when eventItem is "APP_CLOSE" => FinWaitOneState,
            SynReceivedState when eventItem is "RCV_ACK" => EstablishedState,
            SynSentState when eventItem is "RCV_SYN_ACK" => EstablishedState,
            FinWaitOneState when eventItem is "RCV_FIN_ACK" => TimeWaitState,
            ClosingState when eventItem is "RCV_ACK" => TimeWaitState,
            FinWaitTwoState when eventItem is "RCV_FIN" => TimeWaitState,
            EstablishedState when eventItem is "RCV_FIN" => ClosedWaitState,
            FinWaitOneState when eventItem is "RCV_FIN" => ClosingState,
            FinWaitOneState when eventItem is "RCV_ACK" => FinWaitTwoState,
            ClosedWaitState when eventItem is "APP_CLOSE" => LastAckState,
            _ => string.Empty
        };
}
