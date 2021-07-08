using LexiconAssigment3_TodoItConsoleApp.Data;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LexiconAssigment3_TodoItConsoleApp.Tests
{
    public class TodoSequencerTest
    {
        [Fact]
        public void NextTodoIdWorkcorrect()
        {
            //Assert
            Assert.Equal(0, TodoSequencer.Reset());
            Assert.Equal(1, TodoSequencer.NextTodoId());
            Assert.Equal(2, TodoSequencer.NextTodoId());
            Assert.Equal(3, TodoSequencer.NextTodoId());
            Assert.Equal(4, TodoSequencer.NextTodoId());
        }

        [Fact]
        public void ResetTodoIdWorkCorrect()
        {
            Assert.Equal(0, TodoSequencer.Reset());
            Assert.Equal(1, TodoSequencer.NextTodoId());
            Assert.Equal(2, TodoSequencer.NextTodoId());
            Assert.Equal(3, TodoSequencer.NextTodoId());
            Assert.Equal(0, TodoSequencer.Reset());
            Assert.Equal(1, TodoSequencer.NextTodoId());
            Assert.Equal(2, TodoSequencer.NextTodoId());
            Assert.Equal(3, TodoSequencer.NextTodoId());
            Assert.Equal(0, TodoSequencer.Reset());

        }
    }
}
