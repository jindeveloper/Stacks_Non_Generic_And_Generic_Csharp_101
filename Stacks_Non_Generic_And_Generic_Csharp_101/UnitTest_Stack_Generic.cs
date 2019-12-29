using Stacks_Non_Generic_And_Generic_Csharp_101.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Stacks_Non_Generic_And_Generic_Csharp_101
{
    public class UnitTest_Stack_Generic
    {
        [Fact]
        public void Test_Different_Ways_To_Create_New_Instance_Generic_Stack()
        {
            //create a new instance of generic stack 
            Stack<Book> stackofBooks = new Stack<Book>();

            //checks whether the declared stackofBooks is not null
            Assert.NotNull(stackofBooks);
            //checks whether the stackofBooks collection count is zero
            //because we haven't added anyting yet
            Assert.True(stackofBooks.Count == 0);

            //create a new instance of book collection and initialize it
            var books = new Book[] {
                new Book { Id =1, Title = "C# in Depth", BookCategory = BookCategory.IT } ,
                new Book { Id =2, Title = "Pro C# 7"  , BookCategory = BookCategory.IT },
                new Book { Id =3, Title = "C# 5.0 In A Nutshell", BookCategory = BookCategory.IT  } };

            //create a new instance of generic stack and pass the book collection
            Stack<Book> stackOfBooks_Csharp = new Stack<Book>(books);

            //checks whether the declared stackofBooks is not null
            Assert.NotNull(stackOfBooks_Csharp);
            //checks whether the stackOfBooks collection count is greater than zero
            Assert.True(stackOfBooks_Csharp.Count > 0);
        }

        [Fact]
        public void Test_AddValues_To_Generic_Stack()
        {
            //create a new instance of stack 
            Stack<Book> stackOfBooks_Csharp = new Stack<Book>();
            //checks whether the stackofBooks collection count is zero
            Assert.True(stackOfBooks_Csharp.Count == 0);

            //lets push some books at the stack
            stackOfBooks_Csharp.Push(new Book { Id = 1, Title = "C# in Depth", BookCategory = BookCategory.IT });
            stackOfBooks_Csharp.Push(new Book { Id = 2, Title = "Pro C# 7", BookCategory = BookCategory.IT });
            stackOfBooks_Csharp.Push(new Book { Id = 3, Title = "C# 5.0 In A Nutshell", BookCategory = BookCategory.IT });
            
            //lets count if there are 3 elements/items inside the stack
            Assert.True(stackOfBooks_Csharp.Count == 3);
        }

        [Fact]
        public void Test_AddValues_To_Stack_And_Iterate_Through_Generic()
        {
            //create a new instance of stack 
            Stack<Book> stackOfBooks_Csharp = new Stack<Book>();

            //lets push some books at the stack
            stackOfBooks_Csharp.Push(new Book { Id =1, Title = "C# in Depth", BookCategory = BookCategory.IT });
            stackOfBooks_Csharp.Push(new Book { Id =2, Title = "Pro C# 7", BookCategory = BookCategory.IT });
            stackOfBooks_Csharp.Push(new Book { Id =3, Title = "C# 5.0 In A Nutshell", BookCategory = BookCategory.IT });
            
            //lets iterate 
            foreach (var item in stackOfBooks_Csharp)
            {
                Console.WriteLine(item);

                Assert.Contains("C#", item.ToString());
            }
        }

        [Fact]
        public void Test_AddValues_To_Stack_And_Get_The_Top_Most_Generic()
        {
            //create a new instance of stack 
            Stack<Book> stackOfBooks_Csharp = new Stack<Book>();

            //lets push some books at the stack
            stackOfBooks_Csharp.Push(new Book { Id =1,Title = "C# in Depth", BookCategory = BookCategory.IT });
            stackOfBooks_Csharp.Push(new Book { Id =2, Title = "Pro C# 7", BookCategory = BookCategory.IT });
            stackOfBooks_Csharp.Push(new Book { Id =3, Title = "C# 5.0 In A Nutshell", BookCategory = BookCategory.IT });

            //lets get the top most item in the stack collection
            Book topMost = stackOfBooks_Csharp.Peek();
            string topMostInString = topMost.ToString();
          
            Assert.True(topMostInString.ToUpper() == "C# 5.0 IN A NUTSHELL");
        }

        [Fact]
        public void Test_AddValue_To_Stack_And_Iterate_Then_Remove_Using_Pop_Generic()
        {
            //create a new instance of stack 
            Stack<Book> stackOfBooks_Csharp = new Stack<Book>();

            //lets push some books at the stack
            stackOfBooks_Csharp.Push(new Book { Id =1, Title = "C# in Depth", BookCategory = BookCategory.IT });
            stackOfBooks_Csharp.Push(new Book { Id =2, Title = "Pro C# 7", BookCategory = BookCategory.IT });
            stackOfBooks_Csharp.Push(new Book { Id =3, Title = "C# 5.0 In A Nutshell", BookCategory = BookCategory.IT });

            while (stackOfBooks_Csharp.Count > 0)
            {
                //remove the item and returns the item
                Book topMost = stackOfBooks_Csharp.Pop();

                //topmost that was removed
                string topMostInString = topMost.ToString();

                Assert.True(stackOfBooks_Csharp.Count >= 0);
            }

            //expecting to have an empty stack collection
            Assert.True(stackOfBooks_Csharp.Count == 0);
        }

        [Fact]
        public void Test_AddValue_To_Stack_And_Use_Contains_Method_Generic()
        {
            //create a new instance of stack 
            Stack<Book> stackOfBooks_Csharp = new Stack<Book>();

            Assert.NotNull(stackOfBooks_Csharp);

            //lets push some books at the stack
            stackOfBooks_Csharp.Push(new Book { Title = "C# in Depth", BookCategory = BookCategory.IT });
            stackOfBooks_Csharp.Push(new Book { Title = "Pro C# 7", BookCategory = BookCategory.IT });
            stackOfBooks_Csharp.Push(new Book { Title = "C# 5.0 In A Nutshell", BookCategory = BookCategory.IT });

            var bookToCheck = new Book { Title = "C# in Depth", BookCategory = BookCategory.IT };
            var bookToCheck2 = new Book{ Title = "C# in Depth II", BookCategory = BookCategory.IT };

            //check whether it contains C# in Depth with the stack collection
            Assert.True(stackOfBooks_Csharp.Contains(bookToCheck));
            Assert.False(stackOfBooks_Csharp.Contains(bookToCheck2));

            Assert.Contains(stackOfBooks_Csharp, book => book.Title == "C# in Depth");
            
            Assert.False(stackOfBooks_Csharp.Contains(bookToCheck2));
        }


        [Fact]
        public void Test_AddValue_To_Stack_And_Clear_Items_Generic()
        {
            //create a new instance of stack 
            Stack<Book> stackOfBooks_Csharp = new Stack<Book>();

            Assert.NotNull(stackOfBooks_Csharp);

            //lets push some books at the stack
            stackOfBooks_Csharp.Push(new Book { Title = "C# in Depth", BookCategory = BookCategory.IT });
            stackOfBooks_Csharp.Push(new Book { Title = "Pro C# 7", BookCategory = BookCategory.IT });
            stackOfBooks_Csharp.Push(new Book { Title = "C# 5.0 In A Nutshell", BookCategory = BookCategory.IT });

            Assert.True(stackOfBooks_Csharp.Count > 0);

            //clear or remove all the items in the stack collection
            stackOfBooks_Csharp.Clear();

            Assert.True(stackOfBooks_Csharp.Count == 0);
        }
    }
}
    