using NUnit.Framework;
using System;

namespace AlsoLet.Tests
{
    public class Class1
    {
        [Test]
        public void Also()
        {
            var instance = new Something() { Name = @"C:\A.pdf", };

            Something Proceed()
            {
                return instance.Clone()
                    .Also(
                        it =>
                        {
                            it.Name = FixName(it.Name);
                        }
                    );
            }

            var result = Proceed();

            Assert.That(result.Name, Is.EqualTo("C__A.pdf"));
        }

        private string FixName(string path)
            => path
                .Replace(":", "_")
                .Replace("\\", "_")
                ;

        private class Something
        {
            public string Name { get; set; }

            public Something Clone()
            {
                return (Something)MemberwiseClone();
            }
        }

        [Test]
        public void Let()
        {
            string Proceed()
            {
                return new Random(1).Next(-100, 100)
                    .Let(
                        number => (number < 0)
                            ? $"{number} is negative"
                            : $"{number} is zero or positive"
                    );
            }

            var result = Proceed();
            Console.WriteLine(result);
            Assert.That(result, Is.EqualTo("-51 is negative"));
        }
    }
}
