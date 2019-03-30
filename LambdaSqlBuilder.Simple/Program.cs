using System;

namespace LambdaSqlBuilder.Simple
{
    class Program
    {
        static void Main(string[] args)
        {
            var query = new SqlLam<Entity>().Where(t => t.Name=="a");
            Console.WriteLine(query.ToSql());
            Console.ReadLine();
        }
    }
    class Entity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int? Age { get; set; }
    }
}
