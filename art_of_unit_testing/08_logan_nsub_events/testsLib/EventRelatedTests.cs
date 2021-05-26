using System;
using lib;
using NSubstitute;
using NUnit.Framework;

namespace testsLib
{
    [TestFixture]
    public class EventRelatedTests
    {

        [Test]
        public void ctor_WhenViewIsLoaded_CallsViewRender()
        {
            var mockView = Substitute.For<IView>();

            Presenter p = new Presenter(mockView);
            mockView.Loaded += Raise.Event<Action>(); // trigger the event with nsub

            mockView.Received().Render(Arg.Is<string>(s => s.Contains("Hello World"))); // check the view was called
        }


    }
}