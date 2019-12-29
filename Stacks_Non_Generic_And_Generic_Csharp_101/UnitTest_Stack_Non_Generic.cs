using System;
using System.Collections;
using Xunit;

namespace Stacks_Non_Generic_And_Generic_Csharp_101
{
    public class UnitTest_Stack_Non_Generic
    {
        [Fact]
        public void Test_Different_Ways_To_Create_New_Instance_Stack_NonGeneric()
        {
            //create a new instance of stack 
            Stack stackofBooks = new Stack();

            //checks whether the declared stackofBooks is not null
            Assert.NotNull(stackofBooks);
            //checks whether the stackofBooks collection count is zero
            //because we haven't added anyting yet
            Assert.True(stackofBooks.Count == 0);

            //create a new instance of string collection of books and initialize it
            string[] books = new string[] { "C# in Depth", "Pro C# 7", "C# 5.0 In A Nutshell" };

            //create a new instance of stack and pass the book collection
            Stack stackOfBooks_Csharp = new Stack(books);

            //checks whether the declared stackofBooks is not null
            Assert.NotNull(stackOfBooks_Csharp);
            //checks whether the stackOfBooks collection count is greater than zero
            Assert.True(stackOfBooks_Csharp.Count > 0);
        }

        [Fact]
        public void Test_AddValues_To_Stack_NonGeneric()
        { 
            //create a new instance of stack 
            Stack stackOfBooks_Csharp = new Stack();
            //checks whether the stackofBooks collection count is zero
            Assert.True(stackOfBooks_Csharp.Count == 0);

            //lets push some books at the stack
            stackOfBooks_Csharp.Push("C# in Depth");
            stackOfBooks_Csharp.Push("Pro C# 7");
            stackOfBooks_Csharp.Push("C# 5.0 In A Nutshell");

            //lets count if there are 3 elements/items inside the stack
            Assert.True(stackOfBooks_Csharp.Count == 3);
        }

        [Fact]
        public void Test_AddValues_To_Stack_And_Iterate_Through_NonGeneric()
        {
            //create a new instance of stack 
            Stack stackOfBooks_Csharp = new Stack();

            //lets push some books at the stack
            stackOfBooks_Csharp.Push("C# in Depth");
            stackOfBooks_Csharp.Push("Pro C# 7");
            stackOfBooks_Csharp.Push("C# 5.0 In A Nutshell");

            //lets iterate 
            foreach (var item in stackOfBooks_Csharp)
            {
                Console.WriteLine(item);

                Assert.Contains("C#", item.ToString());
            }
        }

        [Fact]
        public void Test_AddValues_To_Stack_And_Get_The_Top_Most_NonGeneric()
        {
            //create a new instance of stack 
            Stack stackOfBooks_Csharp = new Stack();

            //lets push some books at the stack
            stackOfBooks_Csharp.Push("C# in Depth");
            stackOfBooks_Csharp.Push("Pro C# 7");
            stackOfBooks_Csharp.Push("C# 5.0 In A Nutshell");

            //lets get the top most item in the stack collection
            object topMost = stackOfBooks_Csharp.Peek();
            string topMostInString = topMost.ToString(); 

            Assert.True(topMostInString.ToUpper() == "C# 5.0 IN A NUTSHELL");
        }

        [Fact]
        public void Test_AddValue_To_Stack_And_Iterate_Then_Remove_Using_Pop_NonGeneric()
        {
            //create a new instance of stack 
            Stack stackOfBooks_Csharp = new Stack();

            //lets push some books at the stack
            stackOfBooks_Csharp.Push("C# in Depth");
            stackOfBooks_Csharp.Push("Pro C# 7");
            stackOfBooks_Csharp.Push("C# 5.0 In A Nutshell");

            while (stackOfBooks_Csharp.Count > 0)
            {
                //remove the item and returns the item
                object topMost = stackOfBooks_Csharp.Pop();
                
                //topmost that was removed
                string topMostInString = topMost.ToString();

                Assert.True(stackOfBooks_Csharp.Count >= 0);
            }

            //expecting to have an empty stack collection
            Assert.True(stackOfBooks_Csharp.Count == 0);
        }
        
        [Fact]
        public void Test_AddValue_To_Stack_And_Use_Contains_Method_NonGeneric()
        {
            //create a new instance of stack 
            Stack stackOfBooks_Csharp = new Stack();

            Assert.NotNull(stackOfBooks_Csharp);

            //lets push some books at the stack
            stackOfBooks_Csharp.Push("C# in Depth");
            stackOfBooks_Csharp.Push("Pro C# 7");
            stackOfBooks_Csharp.Push("C# 5.0 In A Nutshell");

            //check whether it contains C# in Depth with the stack collection
            Assert.True(stackOfBooks_Csharp.Contains("C# in Depth"));
            Assert.False(stackOfBooks_Csharp.Contains("C#"));
        }

        [Fact]
        public void Test_AddValue_To_Stack_And_Clear_Items_NonGeneric()
        {
            //create a new instance of stack 
            Stack stackOfBooks_Csharp = new Stack();

            Assert.NotNull(stackOfBooks_Csharp);

            //lets push some books at the stack
            stackOfBooks_Csharp.Push("C# in Depth");
            stackOfBooks_Csharp.Push("Pro C# 7");
            stackOfBooks_Csharp.Push("C# 5.0 In A Nutshell");

            Assert.True(stackOfBooks_Csharp.Count > 0);

            //clear or remove all the items in the stack collection
            stackOfBooks_Csharp.Clear();

            Assert.True(stackOfBooks_Csharp.Count == 0);
        }
    }
}
