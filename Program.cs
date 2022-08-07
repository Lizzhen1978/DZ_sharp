// Первая задача
int n1 = System.Int32.Parse(Console.ReadLine());
int n2 = System.Int32.Parse(Console.ReadLine());

if (n1 > n2) {
    Console.WriteLine("Первое больше");
} else {
    Console.WriteLine("Второе больше");
}


// Вторая задача

int n3 = System.Int32.Parse(Console.ReadLine());
int n4 = System.Int32.Parse(Console.ReadLine());
int n5 = System.Int32.Parse(Console.ReadLine());

int max = Math.Max(Math.Max(n3, n4), n5);

Console.WriteLine(max);

// Третья задача
int n6 = System.Int32.Parse(Console.ReadLine());

if (n6 % 2 == 0) {
    Console.WriteLine("Четное");
} else {
    Console.WriteLine("Нечетное");
}

// Четвертая задача
int n7 = System.Int32.Parse(Console.ReadLine());

for (int i = 2; i < n7; i++) {
    if (i % 2 == 0)
        Console.WriteLine(i);
}