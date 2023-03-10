# Основные команды ОС

``` ls ``` - список файлов текущей директории

``` ls -a ``` - список файлов текущей директории вместе со скрытыми файлами

``` cd ~ ``` - переход в корневую директорию

``` cd .. ``` - переход на уровень выше

``` cd ../.. ``` - переход на два уровня выше

``` clear ``` - очистка консоли

``` mkdir Test ``` - создание директории Test

``` touch test.txt ``` - создание файла text.txt

``` cp test.txt test-copy.txt ``` - копирование файла text.txt с новым именем text-copy.txt

``` mv test.txt test_original.txt ``` - переименовываем файл test.txt в test_original.txt

``` echo "Hello" ``` - вывод Hello в терминал

``` echo "Hello" > test_original.txt ``` - добавляем Hello в файл test_original.txt

``` cat test_original.txt ``` - просмотр содержимого файла test_original.txt

``` rm test_original.txt ``` - удаляем файл test_original.txt (полное удаление файл без корзины)

``` rm -r Test ``` безвозвратное удаление директории

<br>

# Основные команды git

## Настройка git

``` git config --global user.name ``` - задаём имя пользователя

``` git config --global user.email ``` - задаём наш email для связи

``` git config --global color.ui auto ``` - задаём вывод ошибок и уведомлений в цвете (подсветки)

``` git config --list ``` - список конфигураций git

## Работа с репозиторием

``` git init ``` - инициализация репозитория

``` git status ``` - состояние репозитория

``` git log ``` - вывод коммитов

``` git log --oneline ``` - вывод коммитов списком

``` git remote add origin https://... ``` -  добавляем синхронизацию между локальными файлами и 'удалённым' репозиторием

``` git remote -v ``` - вывод списка подключенных remote соединений

## Управление файлами репозитория

``` git add test.txt ``` - добавление файла в индекс репозитория

``` git add * ``` - добавление всех файлов в список отслеживаемых (что бы потом закоммитить)

``` git rm --cached test.txt ``` - удаление из отслеживаемых файлов test.txt

``` git commit ``` - создание коммита > далее даём название и наживаем esc > прописываем :wq (запись и выход)

``` git commit -m 'add file' ``` - второй вариант создания коммита сразу с названием "add file"

``` git commit -a ``` - трейтий вариант создания коммита сразу добавляя все файлы переходя в редактор коммитов

``` git commit -am 'add file' ``` - четвёртый вариант добавления коммитов > одной строкой коммитим все файлы и даём название коммиту не  заходя в редактор коммитов

## История изменений

``` git reset 5r4e6 ``` - переход к одному из коммитов

``` git reflog ``` - список изменений всех операций (даже удалёния)

``` git revert 5r4e6 ``` - не сбрасывает состояние нашего репозитория на конкретный коммит, а создаёт новый коммит который отменяет действие совершённое выбранным

``` git restore ``` - сброс состояние файла на указанное (имеет три варианта: hard, mixed, soft)

<br>

## Работа с ветками репозитория

``` git branch ``` -  список веток

``` git branch test ``` - создаём ветку test

``` git checkout test ``` - переключаемся на ветку test

``` git branch test-master master ``` - создание новой ветки test-master относительно ветки master (причём не важно в какой ветке мы сейчас находимся)

``` git checkout -b test ``` - переключение на ветку test, но если таковой не существует, то создаст ветку test

<br>

## Публикация репозитория

```  ``` - 

<br>

____

``` git remote add origin https:// ```

```git branch -M master ```

```git push -u origin master ```
____

Git довольно интересно устроен и в целях экономии места не позволяет добавлять пустые папки. Бывают случаи, что нам необходима такая пустая папка. Для этого существует файл **.gitkeep** в него мы можем добавить images/ storage/
Помимо этого существует ещё файл **.gitignore** который игнорирует не нужные файлы .env temp/*
