// Lets declare an array first

string[] WeekDay = ["sun", "mon", "tue", "wed", "thu", "fri", "sat"];

// displaying the length of an array

Console.WriteLine("The length of an array is " + WeekDay.Length);
foreach (string item in WeekDay)
{
    Console.WriteLine(item);
}

// printing out each weekday on console
/*
Console.WriteLine("today is " + WeekDay[0]);
Console.WriteLine("today is " + WeekDay[1]);
Console.WriteLine("today is " + WeekDay[2]);
Console.WriteLine("today is " + WeekDay[3]);
Console.WriteLine("today is " + WeekDay[4]);
Console.WriteLine("today is " + WeekDay[5]);
Console.WriteLine("today is " + WeekDay[6]);
*/

// even though we can print out the weekdays manually we can use for loop to print out the weekdays

//for (int i = 0; i < WeekDay.Length; i++)
//{
//    Console.WriteLine(WeekDay[i]);
//}


// lets do it on different thing maybe aninteger

int[] newNumLists = [12, 24, 36, 48, 60, 72, 84, 96, 120];

// lets use for loop to print it out

//for (int i = 0;i < newNumLists.Length; i++)
//{
//    Console.WriteLine(newNumLists[i]);
//}

//lets use the foreach loop to print out it in console

foreach (int item in newNumLists)
{
    Console.WriteLine(item);
}