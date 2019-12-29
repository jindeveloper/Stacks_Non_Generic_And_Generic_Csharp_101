using System;
using System.Diagnostics.CodeAnalysis;

namespace Stacks_Non_Generic_And_Generic_Csharp_101.Model
{
    public enum BookCategory
    {
        IT = 0,
        CRIME = 1,
        SPORTS = 2
    }
    public class Book : IEquatable<Book>
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public BookCategory BookCategory { get; set; }

        public bool Equals([AllowNull] Book other)
        {
            return this.Title == other.Title;
        }

        public override string ToString()
        {
            return this.Title;
        }
    }
}
