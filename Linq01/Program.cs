using LINQ.DataSources;
using LINQ.Models;
using static LINQ.DataSources.Source;
namespace Linq01
{
    internal class Program
    {
		static void Main(string[] args)
		{

			#region practice
			//			var Students = new List<Student>
			//			{
			//				new () {Name = "mahmoud" , Grade =90 , Major = "CS"},
			//				new () {Name = "Ali"     , Grade =81 , Major = "CS"},
			//				new () {Name = "Mariam"  , Grade =88 , Major = "CS"},
			//				new () {Name = "anas"    , Grade =65 , Major = "Math"},
			//				new () {Name = "Sondos"  , Grade =56 , Major = "Math"}
			//			};
			////Query syntax
			//			var result = from s in Students
			//						 where s.Grade >= 80 && s.Major == "CS"
			//						 orderby s.Grade descending
			//						 select new { s.Name, s.Grade};

			//			foreach (var student in result)
			//			{
			//				Console.WriteLine(student);
			//			}

			////Fuent syntax 
			//			var Results = Students.Where(s => s.Grade > 80 && s.Major == "CS")
			//				.OrderByDescending(s => s.Grade)
			//				.Select(s => new { s.Name, s.Grade });
			//			foreach (var student in Results)
			//			{
			//				Console.WriteLine(student);
			//			}

			#endregion

			#region Q1
			var result = ProductList.Where(p => p.Category == "Seafood")
				.Select(p => new { p.ProductName, p.UnitPrice });

			foreach (var item in result)
			{
				Console.WriteLine(item);
			}
			#endregion

			#region  Q2
			var result = ProductList.Select(p => new { p.ProductName });
			foreach (var item in result)
			{
				Console.WriteLine(item);
			}
			#endregion

			#region Q3
			var result = ProductList.OrderBy(p => p.UnitPrice)
				.Select(p => new { p.ProductName, p.UnitPrice });
			foreach (var item in result)
			{
				Console.WriteLine(item);
			}
			#endregion

			#region Q4
			var result = ProductList.Where(p => p.UnitPrice > 10 && p.UnitPrice < 30);
			foreach (var item in result)
			{
				Console.WriteLine(item);
			}
			#endregion

			#region Q5
			var result = ProductList.Where(p => p.UnitsInStock > 0 && p.Category == "Condiments");
			foreach (var item in result)
			{
				Console.WriteLine(item);
			}
			#endregion

			#region Q6
			var result = ProductList.
				Select(p => new
				{
					Name = p.ProductName,
					price = p.UnitPrice,
					StockStatus = p.UnitsInStock > 0 ? "Available" : "out of stock"
				});
			foreach (var item in result)
			{
				Console.WriteLine(item);
			}
			#endregion

			#region Q7
			var result = ProductList.Select((p, i) => $"{i + 1} : {p.ProductName}");
			foreach (var item in result)
			{
				Console.WriteLine(item);
			}
			#endregion

			#region Q8
			var result = ProductList.OrderBy(p => p.Category)
				.ThenByDescending(p => p.UnitPrice);
			foreach (var item in result)
			{
				Console.WriteLine(item);
			}
			#endregion

			#region Q9
			var result = ProductList.Where(p => p.Category == "Beverages")
				.OrderByDescending(p => p.UnitPrice)
				.Select(p => new { p.ProductName, p.UnitsInStock });
			foreach (var item in result)
			{
				Console.WriteLine(item);
			}
			#endregion

			#region Q10
			var result = from c in CustomerList
						 from o in c.Orders
						 where o.OrderDate.Year >= 1997
						 select new
						 {
							 c.CustomerID,
							 o.OrderDate
						 };
			foreach (var item in result)
			{
				Console.WriteLine($"{item.CustomerID} :{item.OrderDate}");
			}
			#endregion

			#region Q11
			var result = ProductList.Select((p, i) => $"position number :{i + 1} : {p.ProductName}");
			foreach (var item in result)
			{
				Console.WriteLine(item);
			}
			#endregion

			#region Q12
			String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
			var result = Arr.OrderBy(a => a.Length)
				.ThenBy(w => w, StringComparer.OrdinalIgnoreCase);
			foreach (String s in Arr)
			{
				Console.WriteLine(s);
			}
			#endregion

			#region Q13

			#endregion



		}
	}
}
