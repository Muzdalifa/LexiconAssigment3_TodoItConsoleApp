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
            //Arrange
            Assert.Equal(0, TodoSequencer.Reset());

            //Act
            int nextTodo1 = TodoSequencer.NextTodoId();
            int nextTodo2 = TodoSequencer.NextTodoId();

            int nextTodo3 = TodoSequencer.NextTodoId();
            int nextTodo4 = TodoSequencer.NextTodoId();

            //Assert
            Assert.True(nextTodo1 < nextTodo2);
            Assert.True(nextTodo3 < nextTodo4);
            Assert.True(nextTodo2 < nextTodo4);
        }

        [Fact]
        public void ResetTodoIdWorkCorrect()
        {
            //Act
            int resultOFClearing1 = TodoSequencer.Reset();
            int nextTodo1 = TodoSequencer.NextTodoId();
            int nextTodo2 = TodoSequencer.NextTodoId();
            int resultOFClearing2 = TodoSequencer.Reset();
            int nextTodo3 = TodoSequencer.NextTodoId();

            //Assert
            Assert.Equal(0, TodoSequencer.Reset());
            Assert.True(resultOFClearing1 == 0);
            Assert.True(nextTodo1 == nextTodo3);
            Assert.True(resultOFClearing2 == 0);
            Assert.True(nextTodo1 < nextTodo2);
        }
    }
}
