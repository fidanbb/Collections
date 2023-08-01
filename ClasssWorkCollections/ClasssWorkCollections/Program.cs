
using System.Collections;
using ClasssWorkCollections.Controller;

//ArrayList arrayList = new ArrayList();

//arrayList.Add(5);
//arrayList.Add("salam");

//foreach (var item in arrayList)
//{
//    Console.WriteLine(item);
//}


//Hashtable hashtable = new Hashtable();

//hashtable.Add(1, "Samir");
//hashtable.Add(2, "Fidan");
//hashtable.Add(3, "Kubra");

//foreach(DictionaryEntry item in hashtable)
//{
//    //Console.WriteLine(item.Key);
//    Console.WriteLine(item.Value);
//}

//SortedList sortedList = new SortedList();

//sortedList.Add(5,"salam5");
//sortedList.Add(3, "salam3");
//sortedList.Add(1, "salam1");

//sortedList.Add("Az", "salam5");
//sortedList.Add("Ca", "salam3");
//sortedList.Add("Ba", "salam1");

//foreach (DictionaryEntry item in sortedList)
//{
//    Console.WriteLine(item.Key);
//    Console.WriteLine(item.Value);
//}

//SortedList<int, string> genericSortedList = new SortedList<int, string>();

//genericSortedList.Add(2, "djh");
//genericSortedList.Add(1, "shalkdj");


//foreach (KeyValuePair<int,string> item in genericSortedList)
//{
//    Console.WriteLine(item.Value);
//}

//Dictionary<int, int> dictionary = new Dictionary<int, int>();

//dictionary.Add(2, 2);
//dictionary.Add(1, 5);

//foreach (KeyValuePair<int,int> item in dictionary)
//{
//    Console.WriteLine(item.Value);
//}

//Dictionary<string, string> users = new Dictionary<string, string>();

//users.Add("admin", "Cahangir");
//users.Add("SuperAdmin", "Sheref");
//users.Add("Member", "Pervin");

//foreach (KeyValuePair<string,string> item in users)
//{
//    if (item.Key=="admin")
//    {
//        Console.WriteLine(item.Value);
//    }
//}

//Stack<int> stack = new Stack<int>();

//stack.Push(1);
//stack.Push(10);
//stack.Push(4);

//foreach (var item in stack)
//{
//    Console.WriteLine(item);
//}

//Queue<int> queue = new Queue<int>();

//queue.Enqueue(1);
//queue.Enqueue(10);
//queue.Enqueue(4);

//foreach (var item in queue)
//{
//    Console.WriteLine(item);
//}


List<int> nums = new List<int>();

nums.Add(1);
nums.Add(2);
nums.Add(3);
nums.Add(6);
nums.Add(6);
nums.Add(8);

//Console.WriteLine(nums[0]);

//foreach (var item in nums)
//{
//    Console.WriteLine(item);
//}

//int[] arr = { 1, 2, 3 };

//var data = arr.ToList();

//var result = nums.ToArray();

//List<int> nums2 = new List<int>();

//nums2.Add(1);
//nums2.Add(2);
//nums2.Add(3);
//nums2.Add(6);

// nums.AddRange(nums2);

//foreach (var item in nums)
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine(nums.Count);

//for (int i = 0; i < nums.Count; i++)
//{
//    Console.WriteLine(nums[i]);
//}


//nums.Remove(6);

//var result = nums.FirstOrDefault(m => m > 5);
//Console.WriteLine(result);

//var result = nums.FindAll(m => m > 5);

//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}

//var result = nums.Exists(x => x == 1);
//Console.WriteLine(result);

//var result = nums.Find(m => m.Equals(1));
//Console.WriteLine(result);

//var result = nums.Where(m => m > 20 || m < 30).FirstOrDefault();
//Console.WriteLine(result);

//var result = nums.Any(m => m == 5);
//Console.WriteLine(result);

EmployeeController employeeController = new();
//employeeController.GetAll();
employeeController.FilterBySalary();