using static LINQ.ListGenerator;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Intro To LINQ

            #region What is LINQ?
            /*
             * Stand For => Language Integrated Query
             * SQL => DQL , C# => Functions (LINQ)
            
             * It provides the ability to .NET languages "like C#" to generate queries to retrieve data from the (Data Source).
            
             * LINQ works with any collection that implements IEnumerable<T> or IQueryable<T>.
               Common sources include arrays, lists, dictionaries, and even remote databases.
             
             * In C#, LINQ is present in [System.Linq] namespace, In this namespace:
                 * "Enumerable class" is part of the [System.Linq] namespace and provides a set of static methods for querying
                    objects (collections) that implement IEnumerable<T>, These methods are known as LINQ.

             * LINQ Methods Named As 'LINQ Operators' Existed at Class "Enumerable".
     
             * Categorized Into 13 Category
             
             * You Can Use "LINQ Operators" Against The Data [Stored In Sequence] Regardless Data Store [Sql Server, MySql, Oracle]
             
             * Sequence (Source of Data): The Object From Class That Implement Interface IEnumerable<T>
                 * 1. Local {Static , XML Data } : L2Object [LINQ to Object] , L2XML [LINQ to XML] 
                 * 2. Remote : L2EF [LINQ to Entity-Framework] 
            */
            #endregion

            #region Example
            //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //// numbers [Local Sequence] => 'List' implement interface 'IList' that Implement interface 'IEnumerable'

            //// List اللي في ال odd numbers عايز اجرع ال => Filtration

            //List<int> oddNumbers01 = new List<int>();

            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //        oddNumbers01.Add(numbers[i]);
            //}

            //Console.Write("Using For Loop: ");
            //foreach (int i in oddNumbers01)
            //    Console.Write($"{i} ");

            //Console.WriteLine("\n/////////////////////////////////////////");

            //List<int> oddNumbers02 = numbers.Where(num => num % 2 == 1).ToList(); // Where(): LINQ Operator

            //Console.Write("Using LINQ: ");
            //foreach (int num in oddNumbers02)
            //    Console.Write($"{num} ");
            #endregion

            #endregion

            #region LINQ Syntax

            #region 1.Fluent Syntax (Method Syntax)
            /*
             * 1.1 Call "LINQ Operators" As Static Method (Call From Enumerable class).
             
             * 1.2 Call "LINQ Operators" As Extension Method (Call From Collection). [Recommended] 
            */

            #region Example
            //List<int> listNumbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };

            /*
             * "var": Is a keyword, it is used to declare an implicit type variable, 
                      that specifies the type of a variable based on initial value.
            */
            //var oddNumbers = Enumerable.Where(listNumbers, number => number % 2 == 1);
            //Console.Write("1.1 Call \"LINQ Operators\" As Static Method (Call From Enumerable class): ");
            //foreach (int num in oddNumbers)
            //    Console.Write($"{num} "); // 1.1 Call "LINQ Operators" As Static Method: 1 3 5 7

            //Console.WriteLine();

            //var evenNumbers = listNumbers.Where(number => number % 2 == 1);
            //Console.Write("\n1.2 Call \"LINQ Operators\" As Extension Method (Call From Collection): ");
            //foreach (int num in evenNumbers)
            //    Console.Write($"{num} "); // 1.2 Call "LINQ Operators" As Extension Method: 2 4 6 8
            #endregion

            #endregion

            #region 2.Query Syntax
            /*
             * Must Be Begin With Keyword 'From'
             * Must be End With 'Select' Or 'Groupby'
            */

            #region Example
            //List<int> listNumbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };

            //var evenNumbers = from number in listNumbers
            //                  where number % 2 == 0
            //                  select number;

            //Console.Write("Query Syntax: ");
            //foreach (int num in evenNumbers)
            //    Console.Write($"{num} "); // Query Syntax: 2 4 6 8
            #endregion

            #endregion

            #endregion

            #region LINQ Execution Ways

            #region 1.Deferred Execution [Latest Version Of Data]
            /*
             * Deferred execution means that the query is not executed at the point where it is defined.
               Instead, it is executed when the query variable is iterated over.
             
             * Operators with Deferred Execution:
                * Most standard query operators (such as Where, Select, OrderBy, GroupBy) exhibit deferred execution.
            */

            #region Example
            //List<int> listNumbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var oddNumbers = listNumbers.Where(X => X % 2 == 1); // Where is Deferred Execution // Defined Query Variable

            //listNumbers.AddRange(new int[] { 11, 12, 13, 14, 15 }); // Latest Version Of listNumbers

            //foreach (var number in oddNumbers)
            //    Console.Write($"{number} "); // 1 3 5 7 9 11 13 15
            /*
             * The results of the 'oddNumbers' reflect the changes made to the 'listNumbers' because
               'oddNumbers' is executed when it is iterated over in the foreach loop. 
            */

            #endregion

            #endregion

            #region 2.Immediate Execution
            /*
             * Immediate execution forces the query to be executed and the results to be generated immediately.
               This is typically achieved by calling methods that force the evaluation of the query, 
               such as ToList(), ToArray(), Count(), Sum(), and others.

             * Immediate execution useful when you want to avoid multiple evaluations of the query.
 
             * Operators with Immediate Execution:
                * "Casting Operators": ToList(), ToArray(), ToDictionary()
                * "Element Operators": First(), FirstOrDefault(), Last(), LastOrDefault(), Single(), SingleOrDefault()
                * "Aggregation Operators": Count(), Sum(), Min(), Max(), Average(), Aggregate()
            */

            #region Example
            //List<int> listNumbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var oddNumbers = listNumbers.Where(X => X % 2 == 1).ToList(); // ToList is Immediate Execution

            //listNumbers.AddRange(new int[] { 11, 12, 13, 14, 15 }); 

            //foreach (var number in oddNumbers)
            //    Console.Write($"{number} "); // 1 3 5 7 9
            #endregion

            #endregion

            #endregion

            #region Data Setup
            //Console.WriteLine(ListGenerator.ProductsList[0]); // ProductID:1, ProductName:Chai, CategoryBeverages, UnitPrice:18.00, UnitsInStock:100
            //Console.WriteLine(CustomersList[0]); // 212, Ahmed Ali, Obere Str. 57, Berlin, , 12209, Germany, 030-0074321, 030-0076545
            #endregion

            #region LINQ Categories

            #region 1.Filtration [Restrication] Operators - (Where)

            #region Where Operator
            /*
              * The Where method (operator) is an extension method that can be used with any collection implements IEnumerable<T>.
              
              * It allows you to filter a sequence of values based on a predicate (a function that returns a boolean value).

              * Syntax: 
                        public static IEnumerable<TSource> Where<TSource>(
                            this IEnumerable<TSource> source,
                            Func<TSource, bool> predicate
                        )
                          * source (collection): The sequence of values to filter.
                          * predicate: A function to test each element for a condition.
                            The predicate takes an element of the sequence as input and returns 'true' if the element 
                            should be included in the result and 'false' otherwise.
               */
            #endregion

            #region Examples

            #region Example1
            //// 1.Get Product Out Of Stock

            //var unitsInStock11 = ProductsList.Where(product => product.UnitsInStock == 0);
            //Console.WriteLine("Fluent Syntax: ");
            //foreach (var item in unitsInStock11)
            //    Console.WriteLine($"{item}");

            //Console.WriteLine();

            //var unitsInStock12 = from product in ProductsList
            //                     where product.UnitsInStock == 0
            //                     select product;

            //Console.WriteLine("Query Syntax: ");
            //foreach (var item in unitsInStock12)
            //    Console.WriteLine($"{item}");
            #endregion

            #region Example2
            //// 2.Get Product In Stock And In Category Of Meat/Poultry

            //var unitsInStock21 = ProductsList.Where(product => product.UnitsInStock > 0 && product.Category == "Meat/Poultry");

            //Console.WriteLine("Fluent Syntax: ");
            //foreach (var item in unitsInStock21)
            //    Console.WriteLine($"{item}");

            //Console.WriteLine();

            //var unitsInStock22 = from product in ProductsList
            //                     where product.UnitsInStock > 0 && product.Category == "Meat/Poultry"
            //                     select product;

            //Console.WriteLine("Query Syntax: ");
            //foreach (var item in unitsInStock22)
            //    Console.WriteLine($"{item}");
            #endregion

            #region Example3
            //// 3.Get Product Out Of Stock in First 10 Elements

            //// Indexed Where => Valid Only With Fluent Syntax
            //var unitsInStock31 = ProductsList.Where((product, index) => product.UnitsInStock == 0 && index <= 10);
            ////var unitsInStock31 = ProductsList.Where((product, index) => product.UnitsInStock == 0 && product.ProductID <= 10

            //Console.WriteLine("Fluent Syntax: ");
            //foreach (var item in unitsInStock31)
            //    Console.WriteLine($"{item}");
            #endregion

            #endregion

            #endregion

            #region 2.Transformation [Projection] Operators (Select, Select Many)
            /*
             * Transformation operators in LINQ are used to project or transform the elements of a sequence into a new form. 
            */

            #region 2.1 Select Operator
            /*
             * The Select operator returns an IEnumerable collection which contains elements based on a transformation function. 
             * It is similar to the SELECT statement in SQL.
             
             * Syntax: 
                       public static IEnumerable<TResult> Select<TSource, TResult>(
                           this IEnumerable<TSource> source,
                           Func<TSource, TResult> selector
                       )
                       * source (collection): The sequence of values to project.
                       * selector: A transform function to apply to each element.
            */
            #endregion

            #region 2.2 SelectMany Operator
            /*
             * Projects sequences of values that are based on a transform function and then flattens them into one sequence.
             
             * It is useful for queries that involve collections of collections.
             
             * Syntax: 
                       public static IEnumerable<TResult> SelectMany<TSource, TResult>(
                           this IEnumerable<TSource> source,
                           Func<TSource, IEnumerable<TResult>> selector
                       )
                       * source (collection): The sequence of values to project.
                       * selector: A transform function to apply to each element, which produces an IEnumerable<T>.
            */
            #endregion

            #region Examples

            #region Example1
            //// 1.Select Product Name

            #region Fluent Syntax
            //var productNames11 = ProductsList.Select(product => product.ProductName);

            //Console.WriteLine("Fluent Syntax:\n");
            //foreach (var name in productNames11) 
            //    Console.WriteLine(name); 
            #endregion

            #region Query Syntax
            //var productNames12 = from name in ProductsList
            //                     select name.ProductName;

            //Console.WriteLine("Query Syntax:\n");
            //foreach (var name in productNames12)
            //    Console.WriteLine(name); 
            #endregion

            #endregion

            #region Example2
            //// 2.Select Customer Name

            #region Fluent Syntax
            //var customerName21 = CustomersList.Select(customer => customer.CustomerName);
            //Console.WriteLine("Fluent Syntax:\n");
            //foreach (var customer in customerName21)
            //    Console.WriteLine(customer); 
            #endregion

            #region Query Syntax
            //var customerName22 = from customer in CustomersList
            //                     select customer.CustomerName;

            //Console.WriteLine("Query Syntax:\n");
            //foreach (var customer in customerName22)
            //    Console.WriteLine(customer); 
            #endregion

            #endregion

            #region Example3
            //// 3.Select Customer Orders

            #region Fluent Syntax
            ////var customerOrders = CustomersList.Select(customer => customer.Orders);
            ////foreach (var orders in customerOrders)
            ////{
            ////    foreach (var order in orders)
            ////        Console.WriteLine(orders);
            ////}

            //var customerOrders31 = CustomersList.SelectMany(customer => customer.Orders);

            //Console.WriteLine("Fluent Syntax:\n");
            //foreach (var order in customerOrders31)
            //    Console.WriteLine(order); 
            #endregion

            #region Query Syntax
            //var customerOrders32 = from customer in CustomersList
            //                       from order in customer.Orders
            //                       select order;

            //Console.WriteLine("Query Syntax:\n");
            //foreach (var order in customerOrders32)
            //    Console.WriteLine(order); 
            #endregion

            #endregion

            #region Example4
            //// 4.Select Product Id and Product Name 

            #region Fluent Syntax
            ////var productIdAndName01 = ProductsList.Select(product => product.ProductID && product.ProductName); // Wrong ❌❌❌

            //// initial value هيتحطلها Product()اللي في ال Properties وكل ال ProductNameو ال ProductID هنا اللي هيطبع ال 
            ////var productIdAndName01 = ProductsList.Select(
            ////    p => new Product()
            ////    {
            ////        ProductID = p.ProductID,
            ////        ProductName = p.ProductName
            ////    });

            ////var productIdAndName01 = ProductsList.Select(
            ////    p => new ProductIdAndName()
            ////    {
            ////        ProductID = p.ProductID,
            ////        ProductName = p.ProductName
            ////    });

            //var productIdAndName41 = ProductsList.Select(
            //    p => new  // Anonyms object : CLR Will Create Class In RunTime And Override on ToString()
            //    {
            //        ProductID = p.ProductID,
            //        p.ProductName
            //    });

            //Console.WriteLine("Fluent Syntax:\n");
            //foreach (var product in productIdAndName41)
            //    Console.WriteLine(product); 
            #endregion

            #region Query Syntax
            //var productIdAndName42 = from p in ProductsList
            //                         select new { p.ProductID, p.ProductName };

            //Console.WriteLine("Query Syntax:\n");
            //foreach (var product in productIdAndName42)
            //    Console.WriteLine(product); 
            #endregion

            #endregion

            #region Example5
            // 5.Select Product In Stock And Apply Discount 10% On Its Price

            #region Fluent Syntax
            ////var productWith10PercentDisc = ProductsList
            ////    .Where(p => p.UnitsInStock > 0)
            ////    .Select(p10Percent => p10Percent.UnitPrice - (p10Percent.UnitPrice * .1M));

            //var productWith10PercentDisc51 = ProductsList
            //    .Where(p => p.UnitsInStock > 0)
            //    .Select(p10Percent => new
            //    {
            //        ID = p10Percent.ProductID,
            //        ProductName = p10Percent.ProductName,
            //        OldPrice = p10Percent.UnitPrice,
            //        DiscountPrice = p10Percent.UnitPrice - (p10Percent.UnitPrice * .1M)
            //    });

            //Console.WriteLine("Fluent Syntax:\n");
            //foreach (var product in productWith10PercentDisc51)
            //    Console.WriteLine(product); 
            #endregion

            #region Query Syntax
            //var productWith10PercentDisc52 = from p10Percent in ProductsList
            //                                 where p10Percent.UnitsInStock > 0
            //                                 select new
            //                                 {
            //                                     ID = p10Percent.ProductID,
            //                                     ProductName = p10Percent.ProductName,
            //                                     OldPrice = p10Percent.UnitPrice,
            //                                     DiscountPrice = p10Percent.UnitPrice - (p10Percent.UnitPrice * .1M)
            //                                 };

            //Console.WriteLine("Query Syntax:\n");
            //foreach (var product in productWith10PercentDisc52)
            //    Console.WriteLine(product);
            #endregion

            #endregion

            #endregion

            #region Indexed Select
            // Indexed Select Valid Only With Fluent Syntax

            //var result = ProductsList
            //    .Where(p => p.UnitsInStock > 0)
            //    .Select((p, i) => new
            //    {
            //        Index = i,
            //        Name = p.ProductName
            //    });
            //foreach (var item in result)
            //    Console.WriteLine(item);
            #endregion

            #endregion

            #region 3.Ording Operators (OrderBy, OrderByDescending, ThenBy, ThenByDescending, Reverse)
            /*
             * Ordering operators used to orders the elements of a sequence based on one or more attributes.
            */

            #region 3.1 OrderBy && 3.2 OrderByDescending
            /*
             * OrderBy: Sorts the elements of a sequence in ascending order according to a key.
             
             * OrderByDescending: Sorts the elements of a sequence in descending order according to a key.
             
             
             * Syntax:
                       public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(
                           this IEnumerable<TSource> source,
                           Func<TSource, TKey> keySelector
                       )
                       
                       public static IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>(
                           this IEnumerable<TSource> source,
                           Func<TSource, TKey> keySelector
                       )

                       * source: The sequence to order.
                       * keySelector: A function to extract a key from an element. 
            */
            #endregion

            #region 3.3 ThenBy && 3.4 ThenByDescending
            /*
             * ThenBy: Performs a subsequent ordering (secondary sort) of the elements in a sequence in ascending order.
             
             * ThenByDescending: Performs a subsequent ordering (secondary sort) of the elements in a sequence in descending order.
            
             * Syntax:
                      public static IOrderedEnumerable<TSource> ThenBy<TSource, TKey>(
                          this IOrderedEnumerable<TSource> source,
                          Func<TSource, TKey> keySelector
                      )
                      
                      public static IOrderedEnumerable<TSource> ThenByDescending<TSource, TKey>(
                          this IOrderedEnumerable<TSource> source,
                          Func<TSource, TKey> keySelector
                      )

                      *source: The sequence to order.
                      *keySelector: A function to extract a key from an element.
             
            */
            #endregion

            #region 3.5 Reverse
            /*
             * Reverse: Inverts the order of the elements in a sequence.

             * Syntax: 
                       public static IEnumerable<TSource> Reverse<TSource>(
                           this IEnumerable<TSource> source
                       )
                       * source: The sequence to reverse.
            */
            #endregion

            #region Examples

            #region Example1
            // 1.Get Products Ordered By Price Ascending

            #region Fluent Syntax
            //var orderedProducts11 = ProductsList.OrderBy(product => product.UnitPrice);

            //Console.WriteLine("Fluent Syntax:\n");
            //foreach (var product in orderedProducts11)
            //    Console.WriteLine(product);
            #endregion

            #region Query Syntax
            //var orderedProducts12 = from product in ProductsList
            //                        orderby product.UnitPrice
            //                        select product;

            //Console.WriteLine("Query Syntax:\n");
            //foreach (var product in orderedProducts12)
            //    Console.WriteLine(product);
            #endregion

            #endregion

            #region Example2
            // 2.Get Products Ordered By Price Descending

            #region Fluent Syntax
            //var orderedProducts21 = ProductsList.OrderByDescending(product => product.UnitPrice);

            //Console.WriteLine("Fluent Syntax:\n");
            //foreach (var product in orderedProducts21)
            //    Console.WriteLine(product);
            #endregion

            #region Query Syntax
            //var orderedProducts22 = from product in ProductsList
            //                        orderby product.UnitPrice descending
            //                        select product;

            //Console.WriteLine("Query Syntax:\n");
            //foreach (var product in orderedProducts22)
            //    Console.WriteLine(product);
            #endregion

            #endregion

            #region Example3
            // 3.Get Products Ordered By Price Ascending and Number Of Items In Stock

            #region Fluent Syntax
            //var orderedProducts31 = ProductsList
            //    .OrderBy(product => product.UnitPrice)
            //    .ThenBy(product => product.UnitsInStock);

            //Console.WriteLine("Fluent Syntax:\n");
            //foreach (var product in orderedProducts31)
            //    Console.WriteLine(product);
            #endregion

            #region Query Syntax
            //var orderedProducts32 = from product in ProductsList
            //                        orderby product.UnitPrice, product.UnitsInStock
            //                        select product;

            //Console.WriteLine("Query Syntax:\n");
            //foreach (var product in orderedProducts32)
            //    Console.WriteLine(product);
            #endregion

            #endregion

            #endregion

            #endregion

            #region 4.Elements Operator (First, FirstOrDefault, Last, LastOrDefault, Single, SingleOrDefault, ElementAt, ElementAtOrDefault)
            /*
             * Element operators return a particular element from a sequence (collection).
             * Immediate Execution (Valid Only With Fluent Syntax).
            */

            #region 4.1 First && 4.2 FirstOrDefault
            /*
             * First: Returns the first element of a sequence.
                      Throws an exception if the sequence is empty.
             
             * FirstOrDefault: Returns the first element of a sequence,
                               or a default value if the sequence is empty. 
            
             * Syntax: 
                       public static TSource First<TSource>(
                           this IEnumerable<TSource> source
                       )
                       
                       public static TSource FirstOrDefault<TSource>(
                           this IEnumerable<TSource> source
                       )
                       * source: The sequence to return an element from.
            */
            #endregion

            #region 4.3 Last && 4.4 LastOrDefault
            /*
             * Last: Returns the last element of a sequence. 
                     Throws an exception if the sequence is empty.

             * LastOrDefault: Returns the last element of a sequence, 
                              or a default value if the sequence is empty.
            
             * Syntax: 
                       public static TSource Last<TSource>(
                           this IEnumerable<TSource> source
                       )
                       
                       public static TSource LastOrDefault<TSource>(
                           this IEnumerable<TSource> source
                       )
                       * source: The sequence to return an element from.
            */
            #endregion

            #region 4.5 Single && 4.6 SingleOrDefault
            /*
             * Single: Returns the only element of a sequence,
                       and throws an exception if there is not exactly one element in the sequence.

             * SingleOrDefault: Returns the only element of a sequence, or a default value if the sequence is empty. 
                                Throws an exception if there is more than one element in the sequence.
            
             * Syntax: 
                       public static TSource Single<TSource>(
                           this IEnumerable<TSource> source
                       )
                       
                       public static TSource SingleOrDefault<TSource>(
                           this IEnumerable<TSource> source
                       )
                       * source: The sequence to return an element from.
            */
            #endregion

            #region 4.7 ElementAt && 4.8 ElementAtOrDefault
            /*
             * ElementAt: Returns the element at a specified index in a sequence.
                          Throws an exception if the index is out of range.

             * ElementAtOrDefault: Returns the element at a specified index in a sequence,
                                   or a default value if the index is out of range.
            
             * Syntax: 
                       public static TSource ElementAt<TSource>(
                           this IEnumerable<TSource> source,
                           int index
                       )
                       
                       public static TSource ElementAtOrDefault<TSource>(
                           this IEnumerable<TSource> source,
                           int index
                       )
                       * source: The sequence to return an element from.
                       * index: The zero-based index of the element to retrieve.
            */
            #endregion

            #region Examples
            ////هيكون الناتج method بتاع ال behavior وعلي اساس ال condition ممكن ادلها methods كل ال

            //List<Product> products = new List<Product>();

            //var firstProduct = ProductsList.First();
            //Console.WriteLine(firstProduct);
            ////var firstProduct02 = products.First(); // Sequence contains no elements
            //var firstProduct02 = products.FirstOrDefault(); // No Product Found
            //Console.WriteLine(firstProduct02?.ProductName ?? "No Product Found");


            //var lastProduct = ProductsList.Last();
            //Console.WriteLine(lastProduct);
            ////var lastProduct02 = products.Last(); // Sequence contains no elements
            //var lastProduct02 = products.LastOrDefault(); // No Product Found
            //Console.WriteLine(lastProduct02?.ProductName ?? "No Product Found");


            //var productAtIndex = ProductsList.ElementAt(5);
            //Console.WriteLine(productAtIndex);
            ////var productAtIndex02 = products.ElementAt(5); // Index was out of range. 
            //var productAtIndex02 = products.ElementAtOrDefault(5); // No Product Found
            //Console.WriteLine(productAtIndex02?.ProductName ?? "No Product Found");


            ////var singleProduct = ProductsList.SingleOrDefault();
            ////Console.WriteLine(singleProduct); // Sequence contains more than one element
            //var singleProduct02 = products.SingleOrDefault();
            //Console.WriteLine(singleProduct02); //
            #endregion

            #endregion

            #region 5.Aggregate Operators

            #region What is Aggregate Operators?
            /*
             * Aggregate operators in LINQ perform mathematical operations on sequences, 
               such as calculating sums, averages, or performing custom aggregations. 
            
             * Immediate Execution
            */
            #endregion

            #region 5.1 Count
            /*
             * The Count operator returns the number of elements in a sequence.
             
             * Syntax: 
                       public static int Count<TSource>(
                           this IEnumerable<TSource> source
                       )
                       * source: The sequence to count elements from.           
            */

            #region Examples
            ////var productsCount = ProductsList.Count; // List Property
            ////var productsCount = ProductsList.Count(); // LINQ Operator
            //var productsCount = ProductsList.Count(p => p.UnitsInStock == 0);
            //Console.WriteLine(productsCount);
            #endregion

            #endregion

            #region 5.2 Sum
            /*
             * The Sum operator computes the sum of a sequence of numeric values.
             
             * Syntax: 
                       public static int Sum(
                           this IEnumerable<TSource> source
                       )
                       * source: The sequence to compute the sum of.          
            */

            #region Example
            //var sumPrices = ProductsList.Sum(p=>p.UnitPrice);
            //Console.WriteLine(sumPrices); // 2222.7100
            #endregion

            #endregion

            #region 5.3 Min && 5.4 Max
            /*
             * Min => The Min operator returns the minimum value in a sequence.
             * Syntax: 
                       public static int Min(
                           this IEnumerable<int> source
                       )
                       * source: The sequence to determine the minimum value of.         
             
             * Max => The Max operator returns the maximum value in a sequence.
             * Syntax: 
                       public static int Max(
                           this IEnumerable<int> source
                       )
                       * source: The sequence to determine the maximum value of.     
             
            */

            #region Example
            //var maxProduct = ProductsList.Max(); // class Product في IComparable<Product> لل implement هنا انا عامل 
            //                                     // يقارن علي اساسه condition لو مش عامل لازم احط
            //Console.WriteLine(maxProduct);

            //var minPrice = ProductsList.Min(p => p.UnitPrice);
            //Console.WriteLine(minPrice); // 2.5000

            #region Hybrid Syntax
            //// Hybrid Syntax : (Query Syntax).Fluent Syntax

            //var minProduct = (from p in ProductsList
            //                  where p.ProductName.Length == ProductsList.Min(p => p.ProductName.Length)
            //                  select p).FirstOrDefault();

            //Console.WriteLine(minProduct);
            #endregion

            #endregion

            #endregion

            #region 5.5 Average
            /*
             * The Average operator computes the average of a sequence of numeric values.

             * Syntax: 
                       public static double Average(
                           this IEnumerable<int> source
                       )
                       * source: The sequence to compute the average of.
            */

            #region Example
            //var avgPrices = ProductsList.Average(p => p.UnitPrice);
            //Console.WriteLine(avgPrices); // 28.866363636363636363636363636
            #endregion

            #endregion

            #region 5.6 Aggregate
            /*
             * The Aggregate operator applies an accumulator function over a sequence, 
               and return the final accumulate value.

             * Syntax: 
                      public static TAccumulate Aggregate<TSource, TAccumulate>(
                          this IEnumerable<TSource> source,
                          TAccumulate seed,
                          Func<TAccumulate, TSource, TAccumulate> func
                      )
                      * source: The sequence to aggregate.
                      * seed: The initial accumulator value.
                      * func: An accumulator function to be invoked on each element.
            */

            #region Example
            //string[] names = { "Rana", "Ahmed", "Omar", "Ali" }; // واحد string انا عايز اجمعهم في 
            //var resultName = names.Aggregate((s1, s2) => $"{s1} {s2}");
            //Console.WriteLine(resultName); // Rana Ahmed Omar Ali
            //// s1 = Rana , s2 = Ahmed
            //// s1 = Rana Ahmed , s2 = Omar
            //// s1 = Rana Ahmed Omar , s2 = Ali
            //// s1 = Rana Ahmed Omar Ali , s2 =

            //int[] number = { 1, 2, 3, 4 };
            //var resultNumber = number.Aggregate((n1, n2) => n1 + n2);
            //Console.WriteLine(resultNumber); // 10
            //// n1 = 1 , n2 = 2
            //// n1 = 3 , n2 = 3
            //// n1 = 6 , n2 = 4
            //// n1 = 10 , n2 = 0
            #endregion

            #endregion

            #endregion

            #region 6.Casting [Conversion] Operators

            #region What is Casting Operators?
            /*
             * Conversion operators in LINQ are used to convert sequences into different types of collections
             
             * Immediate Execution 
            */
            #endregion

            #region 6.1 ToList
            /*
             * The ToList operator takes the element from the given source, and it returns a new List<T>.
            
             * Syntax:
                       public static List<TSource> ToList<TSource>(
                           this IEnumerable<TSource> source
                       )
                       * source: The sequence to convert.
            */

            #region Example
            //List<Product> listOfProducts = ProductsList.Where(p => p.UnitsInStock == 0); 
            //// Cannot convert type 'System.Collections.Generic.IEnumerable<LINQ02.Product>'
            //// to 'System.Collections.Generic.List<LINQ02.Product>'.

            //var listOfProducts = ProductsList.Where(p => p.UnitsInStock == 0);
            //List<Product> listOfProducts = ProductsList.Where(p => p.UnitsInStock == 0).ToList();
            #endregion

            #endregion

            #region 6.2 ToArray
            /*
             * Convert the input elements in the collection to an Array.
            
             * Syntax:
                       public static TSource[] ToArray<TSource>(
                           this IEnumerable<TSource> source
                       )
                       * source: The sequence to convert.
            */

            #region Example
            //Product[] arrayOfProducts = ProductsList.Where(p => p.UnitsInStock == 0); 
            //// Cannot convert type 'System.Collections.Generic.IEnumerable<LINQ02.Product>'
            //// to 'LINQ02.Product[]'.

            //Product[] arrayOfProducts = ProductsList.Where(p => p.UnitsInStock == 0).ToArray();
            #endregion

            #endregion

            #region 6.3 ToDictionary 
            /*
             * The ToDictionary operator converts a sequence to a Dictionary<TKey, TValue>
               based on a specified key selector and an optional value selector.
             
             * Syntax:
                       public static Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(
                           this IEnumerable<TSource> source,
                           Func<TSource, TKey> keySelector
                       )
                       * source: The sequence to convert.
                       * keySelector: A function to extract the key for each element.
                       -------------------------------------------------------------------------------
                       public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(
                           this IEnumerable<TSource> source,
                           Func<TSource, TKey> keySelector,
                           Func<TSource, TElement> elementSelector
                       )
                       * source: The sequence to convert.
                       * keySelector: A function to extract the key for each element.
                       * elementSelector: A function to extract the value for each element (optional).
            */

            #region Example
            //Dictionary<long, Product> products = ProductsList.Where(p => p.UnitsInStock == 0);
            //// Cannot convert type 'System.Collections.Generic.IEnumerable<LINQ02.Product>'
            //// to 'System.Collections.Generic.Dictionary<long, LINQ02.Product>'.

            //Dictionary<long, Product> products01 = ProductsList.Where(p => p.UnitsInStock == 0)
            //    .ToDictionary(p => p.ProductID); // key بس مش عارف اي هوا ال Product هتكون Value هوا عارف ان ال

            //foreach (var product in products01)
            //    Console.WriteLine($"Key: {product.Key},\nValue: {product.Value}\n");


            //Dictionary<long, string> products02 = ProductsList.Where(p => p.UnitsInStock == 0)
            //    .ToDictionary(p => p.ProductID, p => p.ProductName); // Valueولا ال Keyهنا هوا مش عارف لا ال

            //foreach (var product in products02)
            //    Console.WriteLine($"Key: {product.Key},\nValue: {product.Value}\n");
            #endregion

            #endregion

            #region 6.4 ToHashSet
            /*
             * The ToHashSet operator converts a sequence to a HashSet<T>,
               which is a collection that contains no duplicate elements.
            
             * Syntax:
                       public static HashSet<TSource> ToHashSet<TSource>(
                           this IEnumerable<TSource> source
                       )
                       * source: The sequence to convert. 
            */

            #region Example
            //HashSet<Product> products = ProductsList.Where(p => p.UnitsInStock == 0);
            //// Cannot convert type 'System.Collections.Generic.IEnumerable<LINQ02.Product>'
            //// to 'System.Collections.Generic.HashSet<Product>'.

            //HashSet<Product> products = ProductsList.Where(p => p.UnitsInStock == 0).ToHashSet();

            //foreach (var product in products)
            //    Console.WriteLine(product);
            #endregion

            #endregion

            #region 6.5 OfType
            /*
             * The OfType operator filters the elements of an IEnumerable based on a specified type.
               It returns only those elements that can be cast to the specified type
             
             * return the element of the specific type, and another element will be ignored from the list/collection.
            
             * Syntax:
                        public static IEnumerable<TResult> OfType<TResult>(
                            this IEnumerable source
                        )
                        * source: The sequence to filter.
                        * TResult: The type to filter the elements of the sequence by.
            */

            #region Example
            //ArrayList mixedList = new ArrayList { 1, 2, "Three", 4, "Five" };

            //var numbersOnly = mixedList.OfType<int>();
            //List<string> stringsOnly = mixedList.OfType<string>().ToList();

            //foreach (var n in numbersOnly)
            //    Console.WriteLine(n);     

            //foreach (var s in stringsOnly)
            //    Console.WriteLine(s);
            #endregion

            #endregion

            #endregion

            #region 7.Generation Operators

            #region What is Generation Operators?
            /*
             * Generation operators in LINQ are used to create sequences of values. 
             * Deferred Execution.
             * Valid With Fluent Syntax Only.
             * The Only Way To Call Them is As Static Methods [from 'Enumerable' Class].
            */
            #endregion

            #region 7.1 Range
            /*
             * The Range operator generates a sequence of integral numbers within a specified range.
             
             * Syntax:
                       public static IEnumerable<int> Range(
                           int start,
                           int count
                       )
                       * start: The value of the first integer in the sequence.
                       * count: The number of sequential integers to generate.
            */

            #region Example
            //List<int> rangeNumbers = Enumerable.Range(0, 100).ToList(); // From 0 To 99

            //foreach (var range in rangeNumbers)
            //    Console.Write($"{range} ");
            #endregion

            #endregion

            #region 7.2 Repeat
            /*
             * The Repeat operator generates a sequence that contains one repeated value.
             
             * Syntax:
                       public static IEnumerable<TResult> Repeat<TResult>(
                           TResult element,
                           int count
                       )
                       * element: The value to be repeated.
                       * count: The number of times to repeat the value in the generated sequence.
            */

            #region Example
            ////List<int> repeat = Enumerable.Repeat(7, 10).ToList();
            //List<Product> repeat = Enumerable.Repeat(new Product(), 10).ToList();
            //foreach (var i in repeat)
            //    Console.WriteLine($"{i} ");
            #endregion

            #endregion

            #region 7.3 Empty
            /*
             * The Empty operator returns an empty sequence of a specified type.
             
             * Syntax:
                       public static IEnumerable<TResult> Empty<TResult>()
                       * TResult: The type to assign to the elements of the returned sequence.
            */

            #region Example
            //var EmptyProduct = Enumerable.Empty<Product>();
            //foreach (var product in EmptyProduct)
            //    Console.WriteLine(product);
            #endregion

            #endregion

            #endregion

            #region 8.Set Operators [Union Family]

            #region What is Set Operators?
            /*
             * Set operators in LINQ perform set-based operations on sequences. 
             * They work with sequences to produce results based on the concept of sets,
               where duplicates are removed, and specific set-based criteria are applied.
          
             * Deferred Execution
            */
            #endregion

            #region 8.1 Union && 8.2 Concat [UnionAll] 
            /*
             * Union: The Union operator produces the set union of two sequences, 
                      which includes all distinct elements (without duplication) from both sequences.
             * Syntax:
                      public static IEnumerable<TSource> Union<TSource>(
                          this IEnumerable<TSource> first,
                          IEnumerable<TSource> second
                      )
                      * first: The first sequence.
                      * second: The second sequence.
             

             * Concat [UnionAll] : With Duplication.
            */

            #region Example
            //var seq1 = Enumerable.Range(0, 100); // 0 to 99
            //var seq2 = Enumerable.Range(50, 100); // 50 to 149

            ////var res = seq1.Union(seq2);
            //var res = seq1.Concat(seq2);

            //foreach (var item in seq1)
            //    Console.Write($"{item}\t");

            //Console.WriteLine("\n\n");

            //foreach (var item in seq2)
            //    Console.Write($"{item}\t");

            //Console.WriteLine("\n\n");

            //foreach (var item in res)
            //    Console.Write($"{item}\t");
            #endregion

            #endregion

            #region 8.3 Intersect 
            /*
             * The Intersect operator produces the set intersection of two sequences, 
               which includes only elements that are present in both sequences.

             * Syntax:
                      public static IEnumerable<TSource> Intersect<TSource>(
                          this IEnumerable<TSource> first,
                          IEnumerable<TSource> second
                      )
                      * first: The first sequence.
                      * second: The second sequence.
            */

            #region Example
            //var seq1 = Enumerable.Range(0, 100); // 0 to 99
            //var seq2 = Enumerable.Range(50, 100); // 50 to 149

            //var res = seq1.Intersect(seq2);

            //foreach (var item in seq1)
            //    Console.Write($"{item}\t");

            //Console.WriteLine("\n\n");

            //foreach (var item in seq2)
            //    Console.Write($"{item}\t");

            //Console.WriteLine("\n\n");

            //foreach (var item in res)
            //    Console.Write($"{item}\t");
            #endregion

            #endregion

            #region 8.4 Except 
            /*
             * The Except operator produces the set difference of two sequences, 
               which includes elements from the first sequence that are not present in the second sequence.

             * Syntax:
                      public static IEnumerable<TSource> Except<TSource>(
                          this IEnumerable<TSource> first,
                          IEnumerable<TSource> second
                      )
                      * first: The first sequence.
                      * second: The second sequence.
            */

            #region Example
            //var seq1 = Enumerable.Range(0, 100); // 0 to 99
            //var seq2 = Enumerable.Range(50, 100); // 50 to 149

            //var res = seq1.Except(seq2);

            //foreach (var item in seq1)
            //    Console.Write($"{item}\t");

            //Console.WriteLine("\n\n");

            //foreach (var item in seq2)
            //    Console.Write($"{item}\t");

            //Console.WriteLine("\n\n");

            //foreach (var item in res)
            //    Console.Write($"{item}\t");
            #endregion

            #endregion

            #region 8.5 Distinct  
            /*
             * The Distinct operator returns distinct elements from a sequence by removing duplicates.

             * Syntax:
                      public static IEnumerable<TSource> Distinct<TSource>(
                          this IEnumerable<TSource> source
                      )
                      * source: The sequence to remove duplicates from.
            */

            #region Example
            //var seq1 = Enumerable.Range(0, 100); // 0 to 99
            //var seq2 = Enumerable.Range(50, 100); // 50 to 149

            //var res = seq1.Concat(seq2).Distinct();

            //foreach (var item in seq1)
            //    Console.Write($"{item}\t");

            //Console.WriteLine("\n\n");

            //foreach (var item in seq2)
            //    Console.Write($"{item}\t");

            //Console.WriteLine("\n\n");

            //foreach (var item in res)
            //    Console.Write($"{item}\t");
            #endregion

            #endregion

            #endregion

            #region 9.Quantifier Operator

            #region What is Quantifier Operator?
            /*
             * Quantifier operators used to evaluate whether some or all elements in a sequence satisfy a condition. 
             * Return boolean
            */
            #endregion

            #region 9.1 Any
            /*
             * The Any operator checks if any elements in the sequence satisfy a specified condition
               or if the sequence contains any elements.

             * Syntax:
                      public static bool Any<TSource>(
                          this IEnumerable<TSource> source
                      )
                      
                      public static bool Any<TSource>(
                          this IEnumerable<TSource> source,
                          Func<TSource, bool> predicate
                      )
                      * source: The sequence to check.
                      * predicate: A function to test each element for a condition.
            */

            #region Example
            ////var result = ProductsList.Any();
            //var result = ProductsList.Any(p => p.UnitsInStock > 1000);  // If Sequence Contains at least one element math the condition
            //Console.WriteLine(result); // False
            #endregion

            #endregion

            #region 9.2 All 
            /*
             * The All operator checks if all elements in the sequence satisfy a specified condition.

             * Syntax:
                      public static bool All<TSource>(
                          this IEnumerable<TSource> source,
                          Func<TSource, bool> predicate
                      )
                      * source: The sequence to check.
                      * predicate: A function to test each element for a condition.
            */

            #region Example
            //var result = ProductsList.All(p => p.UnitsInStock == 1); // If All Sequence elements math the condition
            //Console.WriteLine(result); // False
            #endregion

            #endregion

            #region 9.3 SequenceEqual  
            /*
             * The SequenceEqual operator in LINQ is used to determine whether two sequences are equal.
             * Two sequences are considered equal if they have the same elements in the same order.

             * Syntax:
                      public static bool SequenceEqual<TSource>(
                          this IEnumerable<TSource> first,
                          IEnumerable<TSource> second
                      )
                      
                      public static bool SequenceEqual<TSource>(
                          this IEnumerable<TSource> first,
                          IEnumerable<TSource> second,
                          IEqualityComparer<TSource> comparer
                      )
                      * first: The first sequence to compare.
                      * second: The second sequence to compare.
                      * comparer: An equality comparer to compare elements (optional).
            */

            #region Example
            //var seq1 = Enumerable.Range(0, 100);
            //var seq2 = Enumerable.Range(50, 100);
            //var result = seq1.SequenceEqual(seq2);
            //Console.WriteLine(result); // False

            //int[] seq1 = { 0, 1, 2, 3 };
            //int[] seq2 = { 1, 0, 2, 3 };
            //var result = seq1.SequenceEqual(seq2);
            //Console.WriteLine(result); // False
            #endregion

            #endregion

            #region 9.4 Contains
            /*
             * The Contains operator checks if a sequence contains a specified element.
             
             * Syntax:
                      public static bool Contains<TSource>(
                          this IEnumerable<TSource> source,
                          TSource value
                      )
                      * source: The sequence to check.
                      * value: The value to locate in the sequence.
            */
            #endregion

            #endregion

            #region 10.Zipping Operator [ZIP]
            /*
             * The Zip operator in LINQ applies a specified function to the corresponding 
               elements of two sequences, producing a sequence of the results. 
            
             * When the sequences have different lengths,
               Zip stops when the end of the shorter sequence is reached 
             
             * Syntax:
                      public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(
                          this IEnumerable<TFirst> first,
                          IEnumerable<TSecond> second,
                          Func<TFirst, TSecond, TResult> resultSelector
                      )
                      * first: The first sequence.
                      * second: The second sequence.
                      * resultSelector: A function that specifies how to combine the corresponding elements of the two sequences.
            */

            #region Example
            //List<int> numbers = new List<int> { 1, 2, 3 };
            //List<string> twoWords = new List<string> { "one", "two" };
            //List<string> threeWords = new List<string> { "one", "two", "three" };

            //var zipped1 = numbers.Zip(threeWords, (n, w) => $"{n}: {w}");
            //var zipped2 = numbers.Zip(twoWords, (n, w) => new { index = n, Word = w });

            //foreach (var item in zipped1)
            //    Console.Write($"{item} ");  // 1: one, 2: two, 3: three

            //Console.WriteLine();

            //foreach (var item in zipped2)
            //    Console.Write($"{item} ");  // { index = 1, Word = one } { index = 2, Word = two }
            #endregion

            #endregion

            #region 11.Grouping Operators

            #region What is Grouping Operators?
            /*
             * Grouping operators in LINQ allow you to group elements of a sequence based on a key.
            */
            #endregion

            #region GroupBy => [Flunet Syntax ]| (group ... by) => [Query Syntax]
            /*
             * The GroupBy operator groups the elements of a sequence according to a specified key selector function. 
             * It returns a sequence of groups, where each group is represented by an IGrouping<TKey, TElement>.
             
             * Syntax:
                       public static IEnumerable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey>(
                           this IEnumerable<TSource> source,
                           Func<TSource, TKey> keySelector
                       )
                       --------------------------------------------------------------------------------------
                       public static IEnumerable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(
                           this IEnumerable<TSource> source,
                           Func<TSource, TKey> keySelector,
                           Func<TSource, TElement> elementSelector
                       )
                       --------------------------------------------------------------------------------------
                       public static IEnumerable<TResult> GroupBy<TSource, TKey, TResult>(
                           this IEnumerable<TSource> source,
                           Func<TSource, TKey> keySelector,
                           Func<TKey, IEnumerable<TSource>, TResult> resultSelector
                       )
                       * source: The sequence to group.
                       * keySelector: A function to extract the key for each element.
                       * elementSelector: A function to map each source element to an element in an IGrouping<TKey, TElement> (optional).
                       * resultSelector: A function to create a result value from each group (optional).
            */

            #region Examples

            #region EX1
            // Get Products Grouped by Category

            #region Query Syntax
            //var groupedProduct = from p in ProductsList
            //                     group p by p.Category;

            //foreach (var category in groupedProduct)
            //{
            //    Console.Write($"CategoryName: {category.Key}\n");
            //    Console.WriteLine($"\nProducts In {category.Key} Category: ");
            //    foreach (var product in category)
            //    {
            //        Console.WriteLine($" - {product.ProductName}");
            //    }
            //    Console.WriteLine("\n----------------------------\n");
            //}
            #endregion

            #region Flunet Syntax
            //IEnumerable<IGrouping<string, Product>> groupedProduct = ProductsList.GroupBy(p => p.Category);

            //foreach (var category in groupedProduct)
            //{
            //    Console.Write($"CategoryName: {category.Key}\n");
            //    Console.WriteLine($"\nProducts In {category.Key} Category: ");
            //    foreach (var product in category)
            //    {
            //        Console.WriteLine($" - {product.ProductName}");
            //    }
            //    Console.WriteLine("\n----------------------------\n");
            //}
            #endregion

            #endregion

            #region EX2
            // Get Products in Stock Grouped by Category

            #region Query Syntax
            //var groupedProduct = from p in ProductsList
            //                     where p.UnitsInStock > 0
            //                     group p by p.Category;

            //foreach (var category in groupedProduct)
            //{
            //    Console.Write($"CategoryName: {category.Key}\n");
            //    Console.WriteLine($"\nProducts In {category.Key} Category: ");
            //    foreach (var product in category)
            //    {
            //        Console.WriteLine($" - {product.ProductName}");
            //    }
            //    Console.WriteLine("\n----------------------------\n");
            //}
            #endregion

            #region Flunet Syntax
            //var groupedProduct = ProductsList
            //    .Where(p => p.UnitsInStock > 0)
            //    .GroupBy(p => p.Category);

            //foreach (var category in groupedProduct)
            //{
            //    Console.Write($"CategoryName: {category.Key}\n");
            //    Console.WriteLine($"\nProducts In {category.Key} Category: ");
            //    foreach (var product in category)
            //    {
            //        Console.WriteLine($" - {product.ProductName}");
            //    }
            //    Console.WriteLine("\n----------------------------\n");
            //}
            #endregion

            #endregion

            #region EX3
            // Get Products in Stock Grouped by Category That Contains More Than 10 Product

            #region Query Syntax
            ////var groupedProduct = from p in ProductsList
            ////                     where p.UnitsInStock > 0
            ////                     group p by p.Category;

            ////var newCategory = from c in groupedProduct
            ////                  where c.Count() > 10
            ////                  select c;

            //var groupedProduct = from p in ProductsList
            //                     where p.UnitsInStock > 0
            //                     group p by p.Category
            //                     into newCategory
            //                     where newCategory.Count() > 10
            //                     select newCategory;


            //foreach (var category in groupedProduct)
            //{
            //    Console.Write($"CategoryName: {category.Key}\n");
            //    Console.WriteLine($"\nProducts In {category.Key} Category: ");
            //    foreach (var product in category)
            //    {
            //        Console.WriteLine($" - {product.ProductName}");
            //    }
            //    Console.WriteLine("\n----------------------------\n");
            //}
            #endregion

            #region Flunet Syntax
            //var groupedProduct = ProductsList
            //    .Where(p => p.UnitsInStock > 0)
            //    .GroupBy(p => p.Category)
            //    .Where(p => p.Count() > 10);

            //foreach (var category in groupedProduct)
            //{
            //    Console.Write($"CategoryName: {category.Key}\n");
            //    Console.WriteLine($"\nProducts In {category.Key} Category: ");
            //    foreach (var product in category)
            //    {
            //        Console.WriteLine($" - {product.ProductName}");
            //    }
            //    Console.WriteLine("\n----------------------------\n");
            //}
            #endregion

            #endregion

            #region EX4
            // Get Category Name of Products in Stock That Contains More Than 10 Product
            // and Number of Product In Each Category

            #region Query Syntax
            //var groupedProduct = from p in ProductsList
            //                     where p.UnitsInStock > 0
            //                     group p by p.Category
            //                     into newCategory
            //                     where newCategory.Count() > 10
            //                     select newCategory;

            //foreach (var category in groupedProduct)
            //{
            //    Console.Write($"CategoryName: {category.Key}\n");
            //    Console.WriteLine($"Number Of Products In {category.Key} Category: {category.Count()} ");
            //    Console.WriteLine($"\nProducts In {category.Key} Category: ");
            //    foreach (var product in category)
            //    {
            //        Console.WriteLine($" - {product.ProductName}");
            //    }
            //    Console.WriteLine("\n----------------------------\n");
            //}
            #endregion

            #region Flunet Syntax
            //var groupedProduct = ProductsList
            //    .Where(p => p.UnitsInStock > 0)
            //    .GroupBy(p => p.Category)
            //    .Where(p => p.Count() > 10);

            //foreach (var category in groupedProduct)
            //{
            //    Console.Write($"CategoryName: {category.Key}\n");
            //    Console.WriteLine($"Number Of Products In {category.Key} Category: {category.Count()} ");
            //    Console.WriteLine($"\nProducts In {category.Key} Category: ");
            //    foreach (var product in category)
            //    {
            //        Console.WriteLine($" - {product.ProductName}");
            //    }
            //    Console.WriteLine("\n----------------------------\n");
            //}
            #endregion

            #endregion

            #endregion

            #endregion

            #endregion

            #region 12.Partitioning Operators
            /*
             * Partitioning operators in LINQ divide a sequence into two parts and return one of the parts. 
            */

            #region 12.1 Take
            /*
             * Returns a specified number of contiguous elements from the start of a sequence.
             
             * Syntax:
                       public static IEnumerable<TSource> Take<TSource>(
                           this IEnumerable<TSource> source,
                           int count
                       )
                       * source: The sequence to return elements from.
                       * count: The number of elements to return.
            */

            #region Example
            //var tenProducts = ProductsList.Where(p => p.UnitsInStock > 0).Take(10); 
            //// Take Numbers of 10 Products That Satisfy The Condition From First Only

            //foreach (var product in tenProducts)
            //    Console.WriteLine(product);
            #endregion

            #endregion

            #region 12.2 Skip
            /*
             * Bypasses a specified number of elements in a sequence and then returns the remaining elements.
             
             * Syntax:
                       public static IEnumerable<TSource> Skip<TSource>(
                           this IEnumerable<TSource> source,
                           int count
                       )
                       * source: The sequence to return elements from.
                       * count: The number of elements to skip.
            */

            #region Example
            //var tenProductsSkipped = ProductsList.Where(p => p.UnitsInStock > 0).Skip(10); 
            //// Skip Numbers of 10 Products That Satisfy The Condition From First Only and return the reminder

            //foreach (var product in tenProductsSkipped)
            //    Console.WriteLine(product);
            #endregion

            #endregion

            #region 12.3 TakeLast
            /*
             * Returns a specified number of contiguous elements from the end of a sequence.
             
             * Syntax:
                       public static IEnumerable<TSource> TakeLast<TSource>(
                           this IEnumerable<TSource> source,
                           int count
                       )
                       * source: The sequence to return elements from.
                       * count: The number of elements to return from the end of the sequence.
            */

            #region Example
            //var lastTenProducts = ProductsList.Where(p => p.UnitsInStock > 0).TakeLast(10);
            //// Take Numbers of 10 Products That Satisfy The Condition From Last Only

            //foreach (var product in lastTenProducts)
            //    Console.WriteLine(product);
            #endregion

            #endregion

            #region 12.4 SkipLast
            /*
             * Bypasses a specified number of elements at the end of a sequence and then returns the remaining elements.
             
             * Syntax:
                       public static IEnumerable<TSource> SkipLast<TSource>(
                           this IEnumerable<TSource> source,
                           int count
                       )
                       * source: The sequence to return elements from.
                       * count: The number of elements to skip from the end of the sequence.
            */

            #region Example
            //var lastTenProductsSkipped = ProductsList.Where(p => p.UnitsInStock > 0).SkipLast(10);
            //// Skip Numbers of 10 Products That Satisfy The Condition From Last Only and return the reminder

            //foreach (var product in lastTenProductsSkipped)
            //    Console.WriteLine(product);
            #endregion

            #endregion

            #region 12.5 TakeWhile
            /*
             * Returns elements from the start of a sequence as long as a specified condition is true.
             
             * Syntax:
                       public static IEnumerable<TSource> TakeWhile<TSource>(
                           this IEnumerable<TSource> source,
                           Func<TSource, bool> predicate
                       )
                       * source: The sequence to return elements from.
                       * predicate: A function to test each element for a condition.
            */

            #region Example
            //int[] numbers = { 9, 4, 8, 3, 0, 5 };
            //var result = numbers.TakeWhile((n, i) => n > i);
            //// Take Elements Will there value large than there index

            //foreach (var product in result)
            //    Console.WriteLine(product);
            #endregion

            #endregion

            #region 12.6 SkipWhile
            /*
             * Bypasses elements in a sequence as long as a specified condition is true
               and then returns the reminding elements.
             
             * Syntax:
                       public static IEnumerable<TSource> SkipWhile<TSource>(
                           this IEnumerable<TSource> source,
                           Func<TSource, bool> predicate
                       )
                       * source: The sequence to return elements from.
                       * predicate: A function to test each element for a condition.
            */

            #region Example
            //int[] numbers = { 9, 4, 8, 3, 0, 5 };
            //var result = numbers.SkipWhile((n, i) => n > i);
            //// Skip Elements Will there value large than there index and return the reminding
            //// بعده Elementsوهيرجعه + كل ال condition بيحقق ال Element لغايت اول  Elements لكل ال Skip هيعمل

            //foreach (var product in result)
            //    Console.WriteLine(product);
            #endregion

            #endregion

            #endregion

            #region 13.Let and into 
            /*
             * Keywords are used in LINQ query expressions to introduce intermediate variables
               and perform additional query operations on the results of a previous query segment.
             
             * Valid With Query Syntax Only
            */

            #region into Keyword [Continue Query With Added A new Range]
            /*
             * The into keyword is used to perform a continuation on a query. 

             * It allows you to continue the query after a 'group' or 'join' clause. 

             * It can also be used to perform additional operations on the result of a subquery.

             * Syntax:
                       var query = from element in collection
                                   group element by key into grouped
                                   select grouped;

                       var query = from element in collection
                                   join otherElement in otherCollection on element.Key equals otherElement.Key into joined
                                   select joined;
            */

            #region Example
            //List<string> names = new List<string> { "Omar", "Ali", "Sally", "Mohamed", "Emad" };
            //var replaceVowelChars = from n in names
            //                        select Regex.Replace(n, "[AEIOUaeiou]", String.Empty)
            //                        into nonVowelNames
            //                        where nonVowelNames.Length > 3
            //                        select nonVowelNames;

            //foreach (var name in replaceVowelChars)
            //    Console.WriteLine(name);
            #endregion

            #endregion

            #region Let Keyword [Continue Query With Added A new Range]
            /*
             * The let keyword is used to create a new range variable and store the result of a subexpression.
             
             * This is useful for simplifying complex expressions and improving readability.
             
             * Syntax:
                      var query = from element in collection
                                  let newVariable = expression
                                  select newVariable;
            */

            #region Example
            //List<string> names = new List<string> { "Omar", "Ali", "Sally", "Mohamed", "Emad" };

            //var replaceVowelChars = from n in names
            //                        let nonVowelNames = Regex.Replace(n, "[AEIOUaeiou]", String.Empty)
            //                        where nonVowelNames.Length > 3
            //                        select nonVowelNames;

            //foreach (var name in replaceVowelChars)
            //    Console.WriteLine(name);
            #endregion

            #endregion

            #endregion

            #endregion
        }
    }
}
