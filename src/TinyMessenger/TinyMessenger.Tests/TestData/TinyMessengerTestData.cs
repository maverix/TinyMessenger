using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TinyMessenger;

namespace TinyMessenger.Tests.TestData {
    public class TestMessage  {
        public TestMessage() {

        }
    }

    public class DerivedMessage<TThings> : TestMessage {
        public TThings Things { get; set; }

        public DerivedMessage() {
        }
    }

    public interface ITestMessageInterface {

    }

    public class InterfaceDerivedMessage<TThings> : ITestMessageInterface {
        public TThings Things { get; set; }

        public InterfaceDerivedMessage() {
        }
    }

    public class TestProxy : ITinyMessageProxy {
        public object Message { get; private set; }

        public void Deliver(object message, ITinyMessageSubscription subscription) {
            this.Message = message;
            subscription.Deliver(message);
        }
    }

}