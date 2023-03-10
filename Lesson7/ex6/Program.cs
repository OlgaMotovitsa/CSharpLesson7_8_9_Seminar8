// Перебор слов


// Следующий пример немного сложнее. Пусть у нас будет некоторый алфавит, состоящий из
// четырёх букв, и нас просят показать все возможные слова, состоящие из T букв. Т может
// равняться 1, 2, 3 и так далее.
// Как решить эту задачу простым способом, итеративным? Итак, пусть у нас будет алфавит,
// который будет храниться в массиве символов. Далее возьмём один цикл и переберём все эти
// буквы. У нас получатся однобуквенные слова. Если потребуются двухбуквенные слова, мы уже
// должны будем использовать цикл в цикле. Соответственно, если нам потребуется
// использовать трёхбуквенные слова, придётся делать цикл в цикле, заключив всё в ещё один
// цикл. И так далее.
// Можете ли вы решить эту задачу в общем виде, если наперёд неизвестно Т? То есть сколько
// букв должно быть в словах? Даю подсказку: можете. Предлагаю сделать небольшой
// перерывчик на три минутки, чтобы вы подумали, каким образом это можно сделать

int n = 1;
void FindWords(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        System.Console.WriteLine($"{n++} {new String(word)} "); return;
    }

    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}

FindWords("аисв" , new char[3]);