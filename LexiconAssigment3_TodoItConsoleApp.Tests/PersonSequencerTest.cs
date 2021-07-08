using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using LexiconAssigment3_TodoItConsoleApp.Data;
namespace LexiconAssigment3_TodoItConsoleApp.Tests
{
    public class PersonSequencerTest
    {
        [Fact]
        public void NextPersonIdWorkcorrect()
        {
            //Assert
            Assert.Equal(0, PersonSequencer.Reset());
            Assert.Equal(1, PersonSequencer.NextPersonId());
            Assert.Equal(2, PersonSequencer.NextPersonId());
            Assert.Equal(3, PersonSequencer.NextPersonId());
            Assert.Equal(4, PersonSequencer.NextPersonId());
        }

        [Fact]
        public void ResetPersonIdWorkCorrect()
        {
            Assert.Equal(0, PersonSequencer.Reset());
            Assert.Equal(1, PersonSequencer.NextPersonId());
            Assert.Equal(2, PersonSequencer.NextPersonId());
            Assert.Equal(3, PersonSequencer.NextPersonId());
            Assert.Equal(0, PersonSequencer.Reset());
            Assert.Equal(1, PersonSequencer.NextPersonId());
            Assert.Equal(2, PersonSequencer.NextPersonId());
            Assert.Equal(3, PersonSequencer.NextPersonId());

        }
    }
}
