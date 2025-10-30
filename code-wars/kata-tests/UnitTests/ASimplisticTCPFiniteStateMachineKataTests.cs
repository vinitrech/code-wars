using FluentAssertions;
using katas.ASimplisticTCPFiniteStateMachine;

namespace kata.tests.UnitTests;

public class ASimplisticTCPFiniteStateMachineKataTests
{
    [Theory]
    [InlineData(new[] { "APP_ACTIVE_OPEN", "RCV_SYN_ACK", "RCV_FIN" }, "CLOSE_WAIT")]
    [InlineData(new[] { "APP_PASSIVE_OPEN", "RCV_SYN", "RCV_ACK" }, "ESTABLISHED")]
    [InlineData(new[] { "APP_ACTIVE_OPEN", "RCV_SYN_ACK", "RCV_FIN", "APP_CLOSE" }, "LAST_ACK")]
    [InlineData(new[] { "APP_ACTIVE_OPEN" }, "SYN_SENT")]
    [InlineData(new[] { "APP_PASSIVE_OPEN", "RCV_SYN", "RCV_ACK", "APP_CLOSE", "APP_SEND" }, "ERROR")]
    public void On_Success_Should_Validate_ASimplisticTCPFiniteStateMachineKata(string[] input, string expectedOutput)
    {
        ASimplisticTCPFiniteStateMachineKata.TraverseStates(input).Should().Be(expectedOutput);
    }
}
