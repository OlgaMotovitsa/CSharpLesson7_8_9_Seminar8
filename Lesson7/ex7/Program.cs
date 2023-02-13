// вывести число от
// большего к меньшему, то итеративно подход принципиально отличаться не будет — придётся
// немного поправить условия. Соответственно, потребуется делать вывод от большего к
// меньшему и производить не инкремент счётчика, а декремент. В то же время, используя
// рекурсию, нам достаточно поменять саму собирающую строку. То есть мы будем прибавлять
// не слева, как это было в предыдущем примере, а справа.

void CatalogInfo(string path, string indent = "")
{
    DirectoryInfo catalogs = new DirectoryInfo(path);
    DirectoryInfo[] catalogs = catalogs.GetDirectories();
    for (int i = 0; i < catalogs.Length; i++)
    {
        System.Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + " ");
    }

    FileInfo[] files = catalog.GetFiles();

    for (int i = 0; i < files.Length; i++ )
    {
        System.Console.WriteLine($"{indent}{files[i].Name}");
    }
}
string path = @"C:\Users\Оля\OneDrive\Рабочий стол\Учеба\CSharp\CSharpLesson7_8_9_Seminar8";
CatalogInfo(path);